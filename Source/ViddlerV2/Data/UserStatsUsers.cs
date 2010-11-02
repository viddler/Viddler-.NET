using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class UserStatsUsers : DataObjectBase
  {
    /// <summary>
    /// Corresponds to the remote Viddler API field "friends"
    /// </summary>
    [XmlElement(ElementName = "friends")]
    public int? Friends
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "followers"
    /// </summary>
    [XmlElement(ElementName = "followers")]
    public int? Followers
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "following"
    /// </summary>
    [XmlElement(ElementName = "following")]
    public int? Following
    {
      get;
      set;
    }
  }
}
