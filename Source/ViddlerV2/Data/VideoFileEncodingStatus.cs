using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Provides enumerated values used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public enum VideoFileEncodingStatus
  {
    /// <summary>
    /// Handles an empty value sent by the remote Viddler API
    /// </summary>
    [XmlEnum(Name = "")]
    Undefined,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "unknown"
    /// </summary>
    [XmlEnum(Name = "unknown")]
    Unknown,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "new"
    /// </summary>
    [XmlEnum(Name = "new")]
    New,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "encoding"
    /// </summary>
    [XmlEnum(Name = "encoding")]
    Encoding,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "success"
    /// </summary>
    [XmlEnum(Name = "success")]
    Success,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "error"
    /// </summary>
    [XmlEnum(Name = "error")]
    Error,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "cancelling"
    /// </summary>
    [XmlEnum(Name = "cancelling")]
    Cancelling,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "cancelled"
    /// </summary>
    [XmlEnum(Name = "cancelled")]
    Cancelled
  }
}
