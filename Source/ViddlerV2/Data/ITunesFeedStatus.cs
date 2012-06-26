using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Provides enumerated values used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public enum ITunesFeedStatus
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
    NoFeed,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "1"
    /// </summary>
    [XmlEnum(Name = "1")]
    ExistingFeed,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "2"
    /// </summary>
    [XmlEnum(Name = "2")]
    ViddlerFeed
  }
}
