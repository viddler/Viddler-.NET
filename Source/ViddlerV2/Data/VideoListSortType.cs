using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Provides enumerated values used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public enum VideoListSortType
  {
    /// <summary>
    /// Handles an empty value sent by the remote Viddler API
    /// </summary>
    [XmlEnum(Name = "")]
    Undefined,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "uploaded-desc"
    /// </summary>
    [XmlEnum(Name = "uploaded-desc")]
    UploadedDescending,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "uploaded-asc"
    /// </summary>
    [XmlEnum(Name = "uploaded-asc")]
    UploadedAscending,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "uploaded-asc"
    /// </summary>
    [XmlEnum(Name = "views-desc")]
    ViewsDescending,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "uploaded-asc"
    /// </summary>
    [XmlEnum(Name = "views-asc")]
    ViewsAscending,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "relevant"
    /// </summary>
    [XmlEnum(Name = "relevant")]
    Relevant
  }
}
