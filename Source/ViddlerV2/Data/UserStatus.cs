using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Provides enumerated values used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public enum UserStatus
  {
    /// <summary>
    /// Handles an empty value sent by the remote Viddler API
    /// </summary>
    [XmlEnum(Name = "")]
    Undefined,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "A"
    /// </summary>
    [XmlEnum(Name = "A")]
    Active,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "N"
    /// </summary>
    [XmlEnum(Name = "N")]
    NotActive,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "D"
    /// </summary>
    [XmlEnum(Name = "D")]
    Deleted,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "F"
    /// </summary>
    [XmlEnum(Name = "F")]
    FlashOnly
  }
}
