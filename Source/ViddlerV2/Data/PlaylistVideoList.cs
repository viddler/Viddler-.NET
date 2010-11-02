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
  public class PlaylistVideoList : DataObjectBase
  {
    /// <summary>
    /// Initializes a new instance of data object class.
    /// </summary>
    public PlaylistVideoList()
    {
      this.Items = new List<Video>();
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "page"
    /// </summary>
    [XmlElement(ElementName = "page")]
    public int? Page
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "per_page"
    /// </summary>
    [XmlElement(ElementName = "per_page")]
    public int? PerPage
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "playlist"
    /// </summary>
    [XmlElement(ElementName = "playlist")]
    public Playlist Playlist
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "videos_list"
    /// </summary>
    [XmlArray(ElementName = "video_list")]
    [XmlArrayItem(ElementName = "video")]
    public List<Video> Items
    {
      get;
      set;
    }
  }
}
