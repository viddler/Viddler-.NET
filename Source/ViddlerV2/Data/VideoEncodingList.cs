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
  public class VideoEncodingList : DataObjectBase
  {
    /// <summary>
    /// Initializes a new instance of data object class.
    /// </summary>
    public VideoEncodingList()
    {
      this.Items = new List<VideoEncoding>();
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "video_encoding_list"
    /// </summary>
    [XmlArray(ElementName = "video_encoding_list")]
    [XmlArrayItem(ElementName = "video_encoding")]
    public List<VideoEncoding> Items
    {
      get;
      set;
    }
  }
}
