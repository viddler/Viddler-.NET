using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class PlaylistRules : DataObjectBase
  {
    /// <summary>
    /// Corresponds to the remote Viddler API field "users"
    /// </summary>
    [XmlElement(ElementName = "users")]
    public string Users
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "max_age"
    /// </summary>
    [XmlElement(ElementName = "max_age")]
    public int? MaxAge
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "tags"
    /// </summary>
    [XmlElement(ElementName = "tags")]
    public string Tags
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "visibility"
    /// </summary>
    [XmlElement(ElementName = "visibility")]
    public PlaylistVisibilityType? Visibility
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "min_views"
    /// </summary>
    [XmlElement(ElementName = "min_views")]
    public int? MinViews
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "max_views"
    /// </summary>
    [XmlElement(ElementName = "max_views")]
    public int? MaxViews
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "min_upload_date"
    /// </summary>
    [XmlElement(ElementName = "min_upload_date")]
    public DateTime? MinUploadDate
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "max_upload_date"
    /// </summary>
    [XmlElement(ElementName = "max_upload_date")]
    public DateTime? MaxUploadDate
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "sort"
    /// </summary>
    [XmlElement(ElementName = "sort")]
    public PlaylistSortType? Sort
    {
      get;
      set;
    }
  }
}
