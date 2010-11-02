using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Collections;
using System.Collections.Generic;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class VideoPermission : DataObjectBase
  {
    /// <summary>
    /// Initializes a new instance of data object class.
    /// </summary>
    public VideoPermission()
    {
      this.Users = new List<User>();
      this.Lists = new List<Playlist>();
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "level"
    /// </summary>
    [XmlElement(ElementName = "level")]
    public VideoPermissionLevel? Level
    {
      get;
      set;
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
    public List<Playlist> Lists
    {
      get;
      set;
    }
  }
}
