using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Provides enumerated values used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public enum CommentListSortType
  {
    /// <summary>
    /// Handles an empty value sent by the remote Viddler API
    /// </summary>
    [XmlEnum(Name = "")]
    Undefined,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "uploaded-desc"
    /// </summary>
    [XmlEnum(Name = "date-desc")]
    DateDescending,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "uploaded-asc"
    /// </summary>
    [XmlEnum(Name = "date-asc")]
    DateAscending
  }
}