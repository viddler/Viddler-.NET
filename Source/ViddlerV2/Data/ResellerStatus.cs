using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Provides enumerated values used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public enum ResellerStatus
  {
    /// <summary>
    /// Handles an empty value sent by the remote Viddler API
    /// </summary>
    [XmlEnum(Name = "")]
    Undefined,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "A"
    /// </summary>
    [XmlEnum(Name = "0")]
    Disabled,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "N"
    /// </summary>
    [XmlEnum(Name = "1")]
    SLE,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "D"
    /// </summary>
    [XmlEnum(Name = "2")]
    DLE
  }
}
