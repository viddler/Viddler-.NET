using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class AdsStatus : DataObjectBase
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
    /// Corresponds to the remote Viddler API field "status"
    /// </summary>
    [XmlElement(ElementName = "status")]
    public string Status
    {
      get;
      set;
    }
  }
}
