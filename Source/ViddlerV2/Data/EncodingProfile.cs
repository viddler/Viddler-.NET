using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class EncodingProfile : DataObjectBase
  {
    /// <summary>
    /// Corresponds to the remote Viddler API field "id"
    /// </summary>
    [XmlElement(ElementName = "id")]
    public string Id
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "name"
    /// </summary>
    [XmlElement(ElementName = "name")]
    public string Name
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "format"
    /// </summary>
    [XmlElement(ElementName = "format")]
    public string Format
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "enabled"
    /// </summary>
    [XmlElement(ElementName = "enabled")]
    public bool? Enabled
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "bitrate"
    /// </summary>
    [XmlElement(ElementName = "bitrate")]
    public int? Bitrate
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "dimensions"
    /// </summary>
    [XmlElement(ElementName = "dimensions")]
    public string Dimensions
    {
      get;
      set;
    }
  }
}
