using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class AdsStatusList : DataObjectBase
  {
    /// <summary>
    /// Initializes a new instance of data object class.
    /// </summary>
    public AdsStatusList()
    {
      this.Items = new List<AdsStatus>();
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "video_ads_status"
    /// </summary>
    [XmlElement(ElementName = "video_ads_status")]
    public List<AdsStatus> Items
    {
      get;
      set;
    }
  }
}
