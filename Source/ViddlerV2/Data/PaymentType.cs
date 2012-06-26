using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Provides enumerated values used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public enum PaymentType
  {
    /// <summary>
    /// Handles an empty value sent by the remote Viddler API
    /// </summary>
    [XmlEnum(Name = "")]
    Undefined,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "credit"
    /// </summary>
    [XmlEnum(Name = "credit")]
    Credit,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "check"
    /// </summary>
    [XmlEnum(Name = "check")]
    Check
  }
}
