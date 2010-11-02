using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class VideoComment : DataObjectBase
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
    /// Corresponds to the remote Viddler API field "status"
    /// </summary>
    [XmlElement(ElementName = "status")]
    public VideoFileStatus? Status
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "ext"
    /// </summary>
    [XmlElement(ElementName = "ext")]
    public string Extension
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
    /// Corresponds to the remote Viddler API field "width"
    /// </summary>
    [XmlElement(ElementName = "width")]
    public int? Width
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "height"
    /// </summary>
    [XmlElement(ElementName = "height")]
    public int? Height
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "size"
    /// </summary>
    [XmlElement(ElementName = "size")]
    public long? Size
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "url"
    /// </summary>
    [XmlElement(ElementName = "url")]
    public string Url
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "html5_video_source"
    /// </summary>
    [XmlElement(ElementName = "html5_video_source")]
    public string Html5VideoSource
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "source"
    /// </summary>
    [XmlElement(ElementName = "source")]
    public bool? Source
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "profile_id"
    /// </summary>
    [XmlElement(ElementName = "profile_id")]
    public string ProfileId
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "video_id"
    /// </summary>
    [XmlElement(ElementName = "video_id")]
    public string VideoId
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "encoding_progress"
    /// </summary>
    [XmlElement(ElementName = "encoding_progress")]
    public int? EncodingProgress
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "encoding_status"
    /// </summary>
    [XmlElement(ElementName = "encoding_status")]
    public VideoFileEncodingStatus? EncodingStatus
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "flash"
    /// </summary>
    [XmlElement(ElementName = "flash")]
    public VideoFileSourceStatus? Flash
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "iphone"
    /// </summary>
    [XmlElement(ElementName = "iphone")]
    public VideoFileSourceStatus? IPhone
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "ipad"
    /// </summary>
    [XmlElement(ElementName = "ipad")]
    public VideoFileSourceStatus? IPad
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "itunes"
    /// </summary>
    [XmlElement(ElementName = "itunes")]
    public VideoFileSourceStatus? ITunes
    {
      get;
      set;
    }
  }
}
