using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a base for data objects returned by Viddler API remote methods.
  /// </summary>
  [Serializable]
  public abstract class DataObjectBase
  {
    /// <summary>
    /// Corresponds to the remote Viddler API field "warnings"
    /// </summary>
    [XmlArray(ElementName = "warnings")]
    [XmlArrayItem(ElementName = "warning")]
    public List<Warning> Warnings
    {
      get;
      set;
    }

    /// <summary>
    /// When overriden in derived class, returns XML representation of the current object.
    /// </summary>
    public XmlDocument Serialize()
    {
      XmlDocument serialized = new XmlDocument();
      serialized.PreserveWhitespace = true;
      serialized.LoadXml(this.ToString());
      serialized.DocumentElement.Attributes.RemoveAll();
      return serialized;
    }

    /// <summary>
    /// When overriden in derived class, returns XML representation of the current object.
    /// </summary>
    public override string ToString()
    {
      XmlWriterSettings settings = new XmlWriterSettings();
      settings.OmitXmlDeclaration = true;
      settings.Encoding = System.Text.Encoding.UTF8;
      settings.ConformanceLevel = ConformanceLevel.Document;
      settings.Indent = true;
      StringBuilder builder = new StringBuilder();

      using (XmlWriter writer = XmlWriter.Create(builder, settings))
      {
        XmlSerializer serializer = new XmlSerializer(this.GetType());

        XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
        namespaces.Add(string.Empty, string.Empty);

        serializer.Serialize(writer, this, namespaces);
      }

      return builder.ToString();
    }
  }
}
