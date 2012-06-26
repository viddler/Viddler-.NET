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
  public class Comment : DataObjectBase
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
    /// Corresponds to the remote Viddler API field "type"
    /// </summary>
    [XmlElement(ElementName = "type")]
    public string Type
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "author"
    /// </summary>
    [XmlElement(ElementName = "author")]
    public string Author
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "rating"
    /// </summary>
    [XmlElement(ElementName = "rating")]
    public int? Rating
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "replies_count"
    /// </summary>
    [XmlElement(ElementName = "replies_count")]
    public int? RepliesCount
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "parent"
    /// </summary>
    [XmlElement(ElementName = "parent")]
    public string Parent
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "text"
    /// </summary>
    [XmlElement(ElementName = "text")]
    public string Text
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "add_time"
    /// </summary>
    [XmlElement(ElementName = "add_time")]
    public UnixTimeStamp? AddTime
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "add_timepoint"
    /// </summary>
    [XmlElement(ElementName = "add_timepoint")]
    public int? AddTimepoint
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
    /// Corresponds to the remote Viddler API field "comments_moderation"
    /// </summary>
    [XmlElement(ElementName = "comments_moderation")]
    public CommentsModeration CommentsModeration
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "video_reply"
    /// </summary>
    [XmlElement(ElementName = "video_reply")]
    public CommentsVideoReply VideoReply
    {
      get;
      set;
    }
  }
}
