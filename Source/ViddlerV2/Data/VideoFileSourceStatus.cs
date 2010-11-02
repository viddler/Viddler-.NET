using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Provides enumerated values used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public enum VideoFileSourceStatus
  {
    /// <summary>
    /// Handles an empty value sent by the remote Viddler API
    /// </summary>
    [XmlEnum(Name = "")]
    Unknown,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "na"
    /// </summary>
    [XmlEnum(Name = "na")]
    NotAvailable,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "on"
    /// </summary>
    [XmlEnum(Name = "on")]
    On,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "off"
    /// </summary>
    [XmlEnum(Name = "off")]
    Off
  }
}
