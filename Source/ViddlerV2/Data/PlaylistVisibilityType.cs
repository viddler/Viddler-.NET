using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Provides enumerated values used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public enum PlaylistVisibilityType
  {
    /// <summary>
    /// Handles an empty value sent by the remote Viddler API
    /// </summary>
    [XmlEnum(Name = "")]
    Unknown,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "private"
    /// </summary>
    [XmlEnum(Name = "private")]
    Private,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "shared"
    /// </summary>
    [XmlEnum(Name = "shared")]
    Shared,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "public"
    /// </summary>
    [XmlEnum(Name = "public")]
    Public
  }
}
