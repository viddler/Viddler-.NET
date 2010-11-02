using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Provides enumerated values used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public enum UserListType
  {
    /// <summary>
    /// Handles an empty value sent by the remote Viddler API
    /// </summary>
    [XmlEnum(Name = "")]
    Unknown,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "everybody"
    /// </summary>
    [XmlEnum(Name = "everybody")]
    Everybody,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "friends"
    /// </summary>
    [XmlEnum(Name = "friends")]
    Friends,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "active"
    /// </summary>
    [XmlEnum(Name = "active")]
    Active
  }
}
