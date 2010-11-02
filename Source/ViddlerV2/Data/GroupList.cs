﻿using System;
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
  public class GroupList : DataObjectBase
  {
    /// <summary>
    /// Initializes a new instance of data object class.
    /// </summary>
    public GroupList()
    {
      this.Items = new List<Group>();
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
    /// Corresponds to the remote Viddler API field "user_list"
    /// </summary>
    [XmlArray(ElementName = "groups")]
    [XmlArrayItem(ElementName = "group")]
    public List<Group> Items
    {
      get;
      set;
    }
  }
}
