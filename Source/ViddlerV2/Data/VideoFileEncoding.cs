using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class VideoFileEncoding : DataObjectBase
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
    public string Ext
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
    /// Corresponds to the remote Viddler API field "encoding_created_at"
    /// </summary>
    [XmlElement(ElementName = "encoding_created_at")]
    public UnixTimeStamp? EncodingCreatedAt
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "encoding_last_updated_at"
    /// </summary>
    [XmlElement(ElementName = "encoding_last_updated_at")]
    public UnixTimeStamp? EncodingLastUpdatedAt
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "encoding_started_at"
    /// </summary>
    [XmlElement(ElementName = "encoding_started_at")]
    public UnixTimeStamp? EncodingStartedAt
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "encoding_token"
    /// </summary>
    [XmlElement(ElementName = "encoding_token")]
    public string EncodingToken
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
    /// Corresponds to the remote Viddler API field "encoding_progress"
    /// </summary>
    [XmlElement(ElementName = "encoding_progress")]
    public int? EncodingProgress
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "encoding_queue_position"
    /// </summary>
    [XmlElement(ElementName = "encoding_queue_position")]
    public int? EncodingQueuePosition
    {
      get;
      set;
    }
  }
}
