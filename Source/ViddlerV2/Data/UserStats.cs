using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class UserStats : DataObjectBase
  {
    /// <summary>
    /// Initializes a new instance of data object class.
    /// </summary>
    public UserStats()
    {
      this.Comments = new UserStatsComments();
      this.Usage = new UserStatsUsage();
      this.Users = new UserStatsUsers();
      this.Videos = new UserStatsVideos();
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "comments"
    /// </summary>
    [XmlElement(ElementName = "comments")]
    public UserStatsComments Comments
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "usage"
    /// </summary>
    [XmlElement(ElementName = "usage")]
    public UserStatsUsage Usage
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "users"
    /// </summary>
    [XmlElement(ElementName = "users")]
    public UserStatsUsers Users
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "videos"
    /// </summary>
    [XmlElement(ElementName = "videos")]
    public UserStatsVideos Videos
    {
      get;
      set;
    }
  }
}
