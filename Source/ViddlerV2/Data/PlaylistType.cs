using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Provides enumerated values used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public enum PlaylistType
  {
    /// <summary>
    /// Handles an empty value sent by the remote Viddler API
    /// </summary>
    [XmlEnum(Name = "")]
    Unknown,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "regular"
    /// </summary>
    [XmlEnum(Name = "regular")]
    Regular,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "smart"
    /// </summary>
    [XmlEnum(Name = "smart")]
    Smart
  }
}
