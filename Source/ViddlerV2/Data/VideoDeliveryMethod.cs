using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Provides enumerated values used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public enum VideoDeliveryMethod
  {
    /// <summary>
    /// Handles an empty value sent by the remote Viddler API
    /// </summary>
    [XmlEnum(Name = "")]
    Undefined,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "0"
    /// </summary>
    [XmlEnum(Name = "0")]
    Progressive,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "1"
    /// </summary>
    [XmlEnum(Name = "1")]
    RTMPStreaming
  }
}
