using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class Video : DataObjectBase
  {
    /// <summary>
    /// Initializes a new instance of data object class.
    /// </summary>
    public Video()
    {
      this.Files = new List<VideoFile>();
      this.Permission = new PermissionSettings();
      this.Tags = new List<Tag>();
      this.Comments = new List<VideoComment>();
      this.ClosedCaptionings = new List<ClosedCaptioning>();
    }

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
    public VideoStatus? Status
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
    /// Corresponds to the remote Viddler API field "user"
    /// </summary>
    [XmlElement(ElementName = "user")]
    public User User
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "title"
    /// </summary>
    [XmlElement(ElementName = "title")]
    public string Title
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "length"
    /// </summary>
    [XmlElement(ElementName = "length")]
    public int? Length
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "description"
    /// </summary>
    [XmlElement(ElementName = "description")]
    public string Description
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "age_limit"
    /// </summary>
    [XmlElement(ElementName = "age_limit")]
    public int? AgeLimit
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
    /// Corresponds to the remote Viddler API field "thumbnail_url"
    /// </summary>
    [XmlElement(ElementName = "thumbnail_url")]
    public string ThumbnailUrl
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "thumbnails_count"
    /// </summary>
    [XmlElement(ElementName = "thumbnails_count")]
    public int? ThumbnailsCount
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "thumbnail_index"
    /// </summary>
    [XmlElement(ElementName = "thumbnail_index")]
    public int? ThumbnailIndex
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "permalink"
    /// </summary>
    [XmlElement(ElementName = "permalink")]
    public string PermaLink
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
    /// Corresponds to the remote Viddler API field "view_count"
    /// </summary>
    [XmlElement(ElementName = "view_count")]
    public int? ViewCount
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "impression_count"
    /// </summary>
    [XmlElement(ElementName = "impression_count")]
    public int? ImpressionCount
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "upload_time"
    /// </summary>
    [XmlElement(ElementName = "upload_time")]
    public UnixTimeStamp? UploadTime
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "made_public_time"
    /// </summary>
    [XmlElement(ElementName = "made_public_time")]
    public UnixTimeStamp? MadePublicTime
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "favorite"
    /// </summary>
    [XmlElement(ElementName = "favorite")]
    public bool? Favorite
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "comment_count"
    /// </summary>
    [XmlElement(ElementName = "comment_count")]
    public int? CommentCount
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "tags"
    /// </summary>
    [XmlArray(ElementName = "tags")]
    [XmlArrayItem(ElementName = "tag")]
    public List<Tag> Tags
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "embed_code"
    /// </summary>
    [XmlElement(ElementName = "embed_code")]
    public string EmbedCode
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "comments"
    /// </summary>
    [XmlArray(ElementName = "comments")]
    [XmlArrayItem(ElementName = "comment")]
    public List<VideoComment> Comments
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "permissions"
    /// </summary>
    [XmlElement(ElementName = "permissions")]
    public PermissionSettings Permission
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
    /// Corresponds to the remote Viddler API field "display_apsect_ratio"
    /// </summary>
    [XmlElement(ElementName = "display_apsect_ratio")]
    public string DisplayApsectRatio
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "files"
    /// </summary>
    [XmlArray(ElementName = "files")]
    [XmlArrayItem(ElementName = "file")]
    public List<VideoFile> Files
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "closed_captioning_list"
    /// </summary>
    [XmlArray(ElementName = "closed_captioning_list")]
    [XmlArrayItem(ElementName = "closed_captioning")]
    public List<ClosedCaptioning> ClosedCaptionings
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "view_token"
    /// </summary>
    [XmlElement(ElementName = "view_token")]
    public string ViewToken
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "itunes_settings"
    /// </summary>
    [XmlElement(ElementName = "itunes_settings")]
    public ITunesSettings ITunes
    {
      get;
      set;
    }
  }
}
