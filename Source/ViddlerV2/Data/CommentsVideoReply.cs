using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class CommentsVideoReply : DataObjectBase
  {
    /// <summary>
    /// Corresponds to the remote Viddler API field "source"
    /// </summary>
    [XmlElement(ElementName = "source")]
    public string Source
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "thumbnail"
    /// </summary>
    [XmlElement(ElementName = "thumbnail")]
    public string Thumbnail
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "duration"
    /// </summary>
    [XmlElement(ElementName = "duration")]
    public double? Duration
    {
      get;
      set;
    }
  }
}
