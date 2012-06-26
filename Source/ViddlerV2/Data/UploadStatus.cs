using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Provides enumerated values used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public enum UploadStatus
  {
    /// <summary>
    /// Handles an empty value sent by the remote Viddler API
    /// </summary>
    [XmlEnum(Name = "")]
    Undefined,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "1"
    /// </summary>
    [XmlEnum(Name = "1")]
    Uploading,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "2"
    /// </summary>
    [XmlEnum(Name = "2")]
    Completed,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "3"
    /// </summary>
    [XmlEnum(Name = "3")]
    Interrupted,
    /// <summary>
    /// Corresponds to the remote Viddler API enumerated value "4"
    /// </summary>
    [XmlEnum(Name = "4")]
    Failed
  }
}
