using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class User : DataObjectBase
  {
    /// <summary>
    /// Corresponds to the remote Viddler API field "username"
    /// </summary>
    [XmlElement(ElementName = "username")]
    public string UserName
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "first_name"
    /// </summary>
    [XmlElement(ElementName = "first_name")]
    public string FirstName
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "last_name"
    /// </summary>
    [XmlElement(ElementName = "last_name")]
    public string LastName
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "about_me"
    /// </summary>
    [XmlElement(ElementName = "about_me")]
    public string AboutMe
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "avatar"
    /// </summary>
    [XmlElement(ElementName = "avatar")]
    public string Avatar
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "age"
    /// </summary>
    [XmlElement(ElementName = "age")]
    public int? Age
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "video_upload_count"
    /// </summary>
    [XmlElement(ElementName = "video_upload_count")]
    public int? VideoUploadCount
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "video_watch_count"
    /// </summary>
    [XmlElement(ElementName = "video_watch_count")]
    public int? VideoWatchCount
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "homepage"
    /// </summary>
    [XmlElement(ElementName = "homepage")]
    public string HomePage
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "gender"
    /// </summary>
    [XmlElement(ElementName = "gender")]
    public UserGender? Gender
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "company"
    /// </summary>
    [XmlElement(ElementName = "company")]
    public string Company
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "city"
    /// </summary>
    [XmlElement(ElementName = "city")]
    public string City
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "friend_count"
    /// </summary>
    [XmlElement(ElementName = "friend_count")]
    public int? FriendCount
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "favorite_video_count"
    /// </summary>
    [XmlElement(ElementName = "favorite_video_count")]
    public int? FavoriteVideoCount
    {
      get;
      set;
    }
  }
}
