using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class Statistics : DataObjectBase
  {
    /// <summary>
    /// Initializes a new instance of data object class.
    /// </summary>
    public Statistics()
    {
      this.Comments = new StatisticsComments();
      this.Usage = new StatisticsUsage();
      this.Users = new StatisticsUsers();
      this.Videos = new StatisticsVideos();
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "comments"
    /// </summary>
    [XmlElement(ElementName = "comments")]
    public StatisticsComments Comments
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "usage"
    /// </summary>
    [XmlElement(ElementName = "usage")]
    public StatisticsUsage Usage
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "users"
    /// </summary>
    [XmlElement(ElementName = "users")]
    public StatisticsUsers Users
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "videos"
    /// </summary>
    [XmlElement(ElementName = "videos")]
    public StatisticsVideos Videos
    {
      get;
      set;
    }
  }
}
