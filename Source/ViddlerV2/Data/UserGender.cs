using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Provides enumerated values used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public enum UserGender
  {
    /// <summary>
    /// Handles an empty value sent by the remote Viddler API
    /// </summary>
    [XmlEnum(Name = "")]
    Unknown,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "m"
    /// </summary>
    [XmlEnum(Name = "m")]
    Male,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "f"
    /// </summary>
    [XmlEnum(Name = "f")]
    Female,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "n"
    /// </summary>
    [XmlEnum(Name = "n")]
    None
  }
}
