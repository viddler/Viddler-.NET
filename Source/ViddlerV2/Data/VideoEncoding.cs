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
  public class VideoEncoding : DataObjectBase
  {
    /// <summary>
    /// Initializes a new instance of data object class.
    /// </summary>
    public VideoEncoding()
    {
      this.Video = new Video();
      this.VideoFileEncodings = new List<VideoFileEncoding>();
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "created_at"
    /// </summary>
    [XmlElement(ElementName = "created_at")]
    public UnixTimeStamp? CreatedAt
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "original_file_name"
    /// </summary>
    [XmlElement(ElementName = "original_file_name")]
    public string OriginalFileName
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "video"
    /// </summary>
    [XmlElement(ElementName = "video")]
    public Video Video
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "video_file_encoding_list"
    /// </summary>
    [XmlArray(ElementName = "video_file_encoding_list")]
    [XmlArrayItem(ElementName = "video_file_encoding")]
    public List<VideoFileEncoding> VideoFileEncodings
    {
      get;
      set;
    }
  }
}
