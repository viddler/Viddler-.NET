using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class VideoTag : DataObjectBase
  {
    /// <summary>
    /// Corresponds to the remote Viddler API field "level"
    /// </summary>
    [XmlElement(ElementName = "type")]
    public VideoTagType? Type
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "text"
    /// </summary>
    [XmlElement(ElementName = "text")]
    public string Text
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "offset"
    /// </summary>
    [XmlElement(ElementName = "offset")]
    public double? Offset
    {
      get;
      set;
    }
  }
}
