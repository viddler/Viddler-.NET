using System;
using System.Xml;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class FeaturedVideo : DataObjectBase
  {
    /// <summary>
    /// Initializes a new instance of data object class.
    /// </summary>
    public FeaturedVideo()
    {
      this.Video = new Video();
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "featured_at"
    /// </summary>
    [XmlElement(ElementName = "featured_at")]
    public string FeaturedAt
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "video"
    /// </summary>
    [XmlElement(ElementName = "video")]
    public Video Video
    {
      get;
      set;
    }
  }
}
