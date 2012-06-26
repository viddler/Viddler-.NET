using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Provides enumerated values used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public enum ImageAlignmentType
  {
    /// <summary>
    /// Handles an empty value sent by the remote Viddler API
    /// </summary>
    [XmlEnum(Name = "")]
    Undefined,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "br"
    /// </summary>
    [XmlEnum(Name = "br")]
    BottomRight,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "b"
    /// </summary>
    [XmlEnum(Name = "b")]
    Bottom,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "bl"
    /// </summary>
    [XmlEnum(Name = "bl")]
    BottomLeft,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "l"
    /// </summary>
    [XmlEnum(Name = "l")]
    Left,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "r"
    /// </summary>
    [XmlEnum(Name = "r")]
    Right,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "tl"
    /// </summary>
    [XmlEnum(Name = "tl")]
    TopLeft,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "t"
    /// </summary>
    [XmlEnum(Name = "t")]
    Top,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "tr"
    /// </summary>
    [XmlEnum(Name = "tr")]
    TopRight
  }
}
