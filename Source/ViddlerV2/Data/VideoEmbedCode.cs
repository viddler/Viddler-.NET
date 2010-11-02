using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class VideoEmbedCode : DataObjectBase
  {
    /// <summary>
    /// Corresponds to the remote Viddler API field "video_id"
    /// </summary>
    [XmlElement(ElementName = "video_id")]
    public string VideoId
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "embed_code"
    /// </summary>
    [XmlElement(ElementName = "embed_code")]
    public string Code
    {
      get;
      set;
    }
  }
}
