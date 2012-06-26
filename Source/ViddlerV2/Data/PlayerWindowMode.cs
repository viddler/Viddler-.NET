using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Provides enumerated values used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public enum PlayerWindowMode
  {
    /// <summary>
    /// Handles an empty value sent by the remote Viddler API
    /// </summary>
    [XmlEnum(Name = "")]
    Undefined,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "transparent"
    /// </summary>
    [XmlEnum(Name = "transparent")]
    Transparent,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "opaque"
    /// </summary>
    [XmlEnum(Name = "opaque")]
    Opaque,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "window"
    /// </summary>
    [XmlEnum(Name = "window")]
    Window
  }
}
