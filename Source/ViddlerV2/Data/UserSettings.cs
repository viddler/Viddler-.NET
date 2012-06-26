using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class UserSettings : DataObjectBase
  {
    /// <summary>
    /// Initializes a new instance of data object class.
    /// </summary>
    public UserSettings()
    {
      this.Notifications = new NotificationSettings();
      this.CommentsModeration = new CommentsModerationSettings();
      this.Comscore = new ComscoreSettings();
      this.Liverail = new LiverailSettings();
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "visible"
    /// </summary>
    [XmlElement(ElementName = "visible")]
    public bool? Visible
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "gravatar"
    /// </summary>
    [XmlElement(ElementName = "gravatar")]
    public bool? Gravatar
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "default_view_permission"
    /// </summary>
    [XmlElement(ElementName = "default_view_permission")]
    public PermissionLevel? DefaultViewPermission
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "default_comment_permission"
    /// </summary>
    [XmlElement(ElementName = "default_comment_permission")]
    public PermissionLevel? DefaultCommentPermission
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "default_download_permission"
    /// </summary>
    [XmlElement(ElementName = "default_download_permission")]
    public PermissionLevel? DefaultDownloadPermission
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "default_embed_permission"
    /// </summary>
    [XmlElement(ElementName = "default_embed_permission")]
    public PermissionLevel? DefaultEmbedPermission
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "default_tag_permission"
    /// </summary>
    [XmlElement(ElementName = "default_tag_permission")]
    public PermissionLevel? DefaultTagPermission
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "whitelisted_domains"
    /// </summary>
    [XmlElement(ElementName = "whitelisted_domains")]
    public string WhitelistedDomains
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "tagging_enabled"
    /// </summary>
    [XmlElement(ElementName = "tagging_enabled")]
    public bool? TaggingEnabled
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "commenting_enabled"
    /// </summary>
    [XmlElement(ElementName = "commenting_enabled")]
    public bool? CommentingEnabled
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "embedding_enabled"
    /// </summary>
    [XmlElement(ElementName = "embedding_enabled")]
    public bool? EmbeddingEnabled
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "download_enabled"
    /// </summary>
    [XmlElement(ElementName = "download_enabled")]
    public bool? DownloadEnabled
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "show_related_videos"
    /// </summary>
    [XmlElement(ElementName = "show_related_videos")]
    public bool? ShowRelatedVideos
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "video_browser_enabled"
    /// </summary>
    [XmlElement(ElementName = "video_browser_enabled")]
    public bool? VideoBrowserEnabled
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "get_link_enabled"
    /// </summary>
    [XmlElement(ElementName = "get_link_enabled")]
    public bool? GetLinkEnabled
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "clicking_through_enabled"
    /// </summary>
    [XmlElement(ElementName = "clicking_through_enabled")]
    public bool? ClickingThroughEnabled
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "embed_code_type"
    /// </summary>
    [XmlElement(ElementName = "embed_code_type")]
    public int? EmbedCodeType
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "video_delivery_method"
    /// </summary>
    [XmlElement(ElementName = "video_delivery_method")]
    public VideoDeliveryMethod? VideoDeliveryMethod
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "hd_playback"
    /// </summary>
    [XmlElement(ElementName = "hd_playback")]
    public bool? HdPlayback
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "mobile_playback"
    /// </summary>
    [XmlElement(ElementName = "mobile_playback")]
    public bool? MobilePlayback
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "default_video_permalink"
    /// </summary>
    [XmlElement(ElementName = "default_video_permalink")]
    public string DefaultVideoPermalink
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "custom_embed_url"
    /// </summary>
    [XmlElement(ElementName = "custom_embed_url")]
    public string CustomEmbedUrl
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "notifications"
    /// </summary>
    [XmlElement(ElementName = "notifications")]
    public NotificationSettings Notifications
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "comments_moderation"
    /// </summary>
    [XmlElement(ElementName = "comments_moderation")]
    public CommentsModerationSettings CommentsModeration
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "comscore"
    /// </summary>
    [XmlElement(ElementName = "comscore")]
    public ComscoreSettings Comscore
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "liverail"
    /// </summary>
    [XmlElement(ElementName = "liverail")]
    public LiverailSettings Liverail
    {
      get;
      set;
    }
  }
}
