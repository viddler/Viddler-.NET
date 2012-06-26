using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.Net;
using System.IO;
using System.Text;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Viddler
{
  /// <summary>
  /// Provides internal helper methods.
  /// </summary>
  internal static class ViddlerHelper
  {
    /// <summary>
    /// Escapes request parameter values.
    /// </summary>
    internal static string EncodeRequestData(string data)
    {
      if (!string.IsNullOrEmpty(data))
      {
        byte[] utfBytes = System.Text.Encoding.UTF8.GetBytes(data);
        char[] safeChars = {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L',
            'M', 'N', 'O', 'P', 'R', 'S', 'T', 'U', 'W', 'X', 'Y', 'Z',
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
            'm', 'n', 'o', 'p', 'r', 's', 't', 'u', 'w', 'x', 'y', 'z',
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
            '\'', '(', ')', '*', '-', '.', '_', '!'
         };

         List<byte> asciiBuilder = new List<byte>();
         foreach (byte charByte in utfBytes)
         {
           char currentChar = (char)charByte;
           if (Array.IndexOf<char>(safeChars, currentChar) > -1)
           {
             asciiBuilder.Add(charByte);
           }
           else if (currentChar == ' ')
           {
             asciiBuilder.Add((byte)('+'));
           }
           else
           {
             asciiBuilder.Add((byte)('%'));
             int[] byteSegments = { ((charByte >> 4) & 15), (charByte & 15) };
             foreach (int segment in byteSegments)
             {
               if (segment <= 9)
               {
                 asciiBuilder.Add((byte)(segment + 48));
               }
               else
               {
                 asciiBuilder.Add((byte)((segment - 10) + 97));
               }
             }
           }
         }
         return System.Text.Encoding.ASCII.GetString(asciiBuilder.ToArray());
      }
      return string.Empty;
    }

    /// <summary>
    /// Returns an enumerated value used by remote Viddler API methods.
    /// </summary>
    internal static string GetEnumName(FieldInfo field)
    {
      foreach (XmlEnumAttribute attribute in field.GetCustomAttributes(typeof(XmlEnumAttribute), true))
      {
        return attribute.Name;
      }
      return null;
    }

    /// <summary>
    /// Returns configuration parameters of the specified contract class, which represents remote Viddler API method.
    /// </summary>
    internal static ViddlerMethodAttribute GetMethodAttribute(Type type)
    {
      foreach (ViddlerMethodAttribute attribute in type.GetCustomAttributes(typeof(ViddlerMethodAttribute), false))
      {
        return attribute;
      }
      return null;
    }

    /// <summary>
    /// Analyzes target response data object and collects properties of promitive type.
    /// </summary>
    internal static Dictionary<string, Type> GetExpectedPrimitiveTypeNodes(Type type)
    {
      Dictionary<string, Type> nodeNameCollection = new Dictionary<string, Type>();
      ViddlerMethodAttribute methodAttribute = ViddlerHelper.GetMethodAttribute(type);
      if (methodAttribute != null)
      {
        string xpath = string.Concat("/", methodAttribute.ElementName, "/");
        ViddlerHelper.CollectExpectedPrimitiveTypeNodes(xpath, type, nodeNameCollection, 0);
      }
      return nodeNameCollection;
    }

    /// <summary>
    /// Analyzes target response data object and collects properties of promitive type.
    /// </summary>
    private static void CollectExpectedPrimitiveTypeNodes(string xpath, Type currentType, Dictionary<string, Type> nodeNameCollection, int depth)
    {
      if (depth > 10) throw new StackOverflowException(string.Concat("Potential stack overflow due to recursively nested data types: ", xpath, "; current depth: ", depth));
      foreach (PropertyInfo propertyInfo in currentType.GetProperties())
      {
        if (propertyInfo.PropertyType.IsValueType)
        {
          string elementName = ViddlerHelper.GetXmlElementName(propertyInfo);
          if (!string.IsNullOrEmpty(elementName))
          {
            nodeNameCollection.Add(string.Concat(xpath, elementName), propertyInfo.PropertyType);
          }
        }
        else if (propertyInfo.PropertyType.IsGenericType && propertyInfo.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
        {
          Type genericArgumentType = propertyInfo.PropertyType.GetGenericArguments()[0];
          if (genericArgumentType.IsValueType)
          {
            string elementName = ViddlerHelper.GetXmlElementName(propertyInfo);
            if (!string.IsNullOrEmpty(elementName))
            {
              nodeNameCollection.Add(string.Concat(xpath, elementName), genericArgumentType);
            }
          }
        }
        else if (propertyInfo.PropertyType.Assembly == typeof(ViddlerHelper).Assembly)
        {
          string elementName = ViddlerHelper.GetXmlElementName(propertyInfo);
          ViddlerHelper.CollectExpectedPrimitiveTypeNodes(string.Concat(xpath, elementName, "/"), propertyInfo.PropertyType, nodeNameCollection, depth + 1);
        }
        else if (propertyInfo.PropertyType.IsGenericType && propertyInfo.PropertyType.GetGenericTypeDefinition() == typeof(List<>) && propertyInfo.PropertyType.GetGenericArguments()[0].Assembly == typeof(ViddlerHelper).Assembly)
        {
          string elementName = ViddlerHelper.GetXmlElementName(propertyInfo);
          if (string.IsNullOrEmpty(elementName))
          {
            elementName = ViddlerHelper.GetXmlArrayName(propertyInfo);
            if (!string.IsNullOrEmpty(elementName))
            {
              elementName = string.Concat(elementName, "/", ViddlerHelper.GetXmlArrayItemName(propertyInfo));
            }
          }
          ViddlerHelper.CollectExpectedPrimitiveTypeNodes(string.Concat(xpath, elementName, "/"), propertyInfo.PropertyType.GetGenericArguments()[0], nodeNameCollection, depth + 1);
        }
      }
    }

    /// <summary>
    /// Returns a node name used by XmlSerializer.
    /// </summary>
    private static string GetXmlElementName(PropertyInfo propertyInfo)
    {
      foreach (XmlElementAttribute attribute in propertyInfo.GetCustomAttributes(typeof(XmlElementAttribute), true))
      {
        return attribute.ElementName;
      }
      return null;
    }

    /// <summary>
    /// Returns a node name used by XmlSerializer.
    /// </summary>
    private static string GetXmlArrayName(PropertyInfo propertyInfo)
    {
      foreach (XmlArrayAttribute attribute in propertyInfo.GetCustomAttributes(typeof(XmlArrayAttribute), true))
      {
        return attribute.ElementName;
      }
      return null;
    }

    /// <summary>
    /// Returns a node name used by XmlSerializer.
    /// </summary>
    private static string GetXmlArrayItemName(PropertyInfo propertyInfo)
    {
      foreach (XmlArrayItemAttribute attribute in propertyInfo.GetCustomAttributes(typeof(XmlArrayItemAttribute), true))
      {
        return attribute.ElementName;
      }
      return null;
    }
  }
}
