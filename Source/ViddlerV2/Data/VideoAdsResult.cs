using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class VideoAdsResult : DataObjectBase
  {
    /// <summary>
    /// Corresponds to the remote Viddler API field "changed"
    /// </summary>
    [XmlElement(ElementName = "changed")]
    public int? Changed
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "video_ids"
    /// </summary>
    [XmlElement(ElementName = "video_ids")]
    public string VideoIds
    {
      get;
      set;
    }
  }
}
