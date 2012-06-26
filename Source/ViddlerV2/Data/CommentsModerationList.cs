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
  public class CommentsModerationList : DataObjectBase
  {
    /// <summary>
    /// Initializes a new instance of data object class.
    /// </summary>
    public CommentsModerationList()
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
    /// Corresponds to the remote Viddler API field "comments"
    /// </summary>
    [XmlArray(ElementName = "comments")]
    [XmlArrayItem(ElementName = "comment")]
    public List<Comment> Items
    {
      get;
      set;
    }
  }
}
