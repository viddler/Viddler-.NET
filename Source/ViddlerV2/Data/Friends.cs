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
  public class Friends : DataObjectBase
  {
    /// <summary>
    /// Initializes a new instance of data object class.
    /// </summary>
    public Friends()
    {
      this.Users = new List<User>();
      this.Lists = new List<FriendList>();
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "users"
    /// </summary>
    [XmlArray(ElementName = "users")]
    [XmlArrayItem(ElementName = "user")]
    public List<User> Users
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "lists"
    /// </summary>
    [XmlArray(ElementName = "lists")]
    [XmlArrayItem(ElementName = "list")]
    public List<FriendList> Lists
    {
      get;
      set;
    }
  }
}
