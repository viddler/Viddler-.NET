using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Provides enumerated values used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public enum VideoStatus
  {
    /// <summary>
    /// Handles an empty value sent by the remote Viddler API
    /// </summary>
    [XmlEnum(Name = "")]
    Undefined,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "ready"
    /// </summary>
    [XmlEnum(Name = "ready")]
    Ready,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "not_ready"
    /// </summary>
    [XmlEnum(Name = "not_ready")]
    NotReady,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "deleted"
    /// </summary>
    [XmlEnum(Name = "deleted")]
    Deleted
  }
}
