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
  public class CommentList : DataObjectBase
  {
    /// <summary>
    /// Initializes a new instance of data object class.
    /// </summary>
    public CommentList()
    {
      this.Items = new List<Comment>();
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
    /// Corresponds to the remote Viddler API field "type"
    /// </summary>
    [XmlElement(ElementName = "sort")]
    public CommentListSortType? Sort
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "comments_list"
    /// </summary>
    [XmlArray(ElementName = "comments_list")]
    [XmlArrayItem(ElementName = "comment")]
    public List<Comment> Items
    {
      get;
      set;
    }
  }
}
