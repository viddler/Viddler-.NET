using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Provides enumerated values used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public enum VideoPermissionLevel
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
    /// Corresponds to the remote Viddler API enumerated value "invite"
    /// </summary>
    [XmlEnum(Name = "invite")]
    Invite,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "embed"
    /// </summary>
    [XmlEnum(Name = "embed")]
    Embed,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "public"
    /// </summary>
    [XmlEnum(Name = "public")]
    Public
  }
}