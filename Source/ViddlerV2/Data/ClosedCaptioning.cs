using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class ClosedCaptioning : DataObjectBase
  {
    /// <summary>
    /// Corresponds to the remote Viddler API field "id"
    /// </summary>
    [XmlElement(ElementName = "id")]
    public string Id
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "enabled"
    /// </summary>
    [XmlElement(ElementName = "enabled")]
    public bool? Enabled
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "language"
    /// </summary>
    [XmlElement(ElementName = "language")]
    public string Language
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "type"
    /// </summary>
    [XmlElement(ElementName = "type")]
    public string Type
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "file_size"
    /// </summary>
    [XmlElement(ElementName = "file_size")]
    public long? FileSize
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "file_url"
    /// </summary>
    [XmlElement(ElementName = "file_url")]
    public string FileUrl
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "default"
    /// </summary>
    [XmlElement(ElementName = "default")]
    public bool? Default
    {
      get;
      set;
    }
  }
}
