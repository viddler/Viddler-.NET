using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class Metadata : DataObjectBase
  {
    /// <summary>
    /// Corresponds to the remote Viddler API field "id"
    /// </summary>
    [XmlElement(ElementName = "id")]
    public int? Id
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "type"
    /// </summary>
    [XmlElement(ElementName = "type")]
    public string Type
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "key"
    /// </summary>
    [XmlElement(ElementName = "key")]
    public string Key
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "value"
    /// </summary>
    [XmlElement(ElementName = "value")]
    public string Value
    {
      get;
      set;
    }
  }
}
