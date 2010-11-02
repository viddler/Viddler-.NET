using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class UserStatsVideos : DataObjectBase
  {
    /// <summary>
    /// Corresponds to the remote Viddler API field "public"
    /// </summary>
    [XmlElement(ElementName = "public")]
    public int? Public
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "private"
    /// </summary>
    [XmlElement(ElementName = "private")]
    public int? Private
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "shared"
    /// </summary>
    [XmlElement(ElementName = "shared")]
    public int? Shared
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "total"
    /// </summary>
    [XmlElement(ElementName = "total")]
    public int? Total
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "favorites"
    /// </summary>
    [XmlElement(ElementName = "favorites")]
    public int? Favorites
    {
      get;
      set;
    }
  }
}
