using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Provides enumerated values used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public enum PlayerType
  {
    /// <summary>
    /// Handles an empty value sent by the remote Viddler API
    /// </summary>
    [XmlEnum(Name = "")]
    Undefined,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "full"
    /// </summary>
    [XmlEnum(Name = "full")]
    Full,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "simple"
    /// </summary>
    [XmlEnum(Name = "simple")]
    Simple,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "mini"
    /// </summary>
    [XmlEnum(Name = "mini")]
    Mini
  }
}
