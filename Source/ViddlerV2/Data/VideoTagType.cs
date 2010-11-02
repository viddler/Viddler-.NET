using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Provides enumerated values used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public enum VideoTagType //?MoreValues
  {
    /// <summary>
    /// Handles an empty value sent by the remote Viddler API
    /// </summary>
    [XmlEnum(Name = "")]
    Unknown,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "global"
    /// </summary>
    [XmlEnum(Name = "global")]
    Global,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "timed"
    /// </summary>
    [XmlEnum(Name = "timed")]
    Timed
  }
}
