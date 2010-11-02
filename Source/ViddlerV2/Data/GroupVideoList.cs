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
  public class GroupVideoList : DataObjectBase
  {
    /// <summary>
    /// Initializes a new instance of data object class.
    /// </summary>
    public GroupVideoList()
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
    /// Corresponds to the remote Viddler API field "group"
    /// </summary>
    [XmlElement(ElementName = "group")]
    public Group Group
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "group_videos"
    /// </summary>
    [XmlArray(ElementName = "group_videos")]
    [XmlArrayItem(ElementName = "video")]
    public List<Video> Items
    {
      get;
      set;
    }
  }
}
