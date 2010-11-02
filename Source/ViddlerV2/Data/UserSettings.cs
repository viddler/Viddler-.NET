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
    /// Corresponds to the remote Viddler API field "show_account"
    /// </summary>
    [XmlElement(ElementName = "show_account")]
    public bool? ShowAccount
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
    /// Corresponds to the remote Viddler API field "show_related_videos"
    /// </summary>
    [XmlElement(ElementName = "show_related_videos")]
    public bool? ShowRelatedVideos
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
    /// Corresponds to the remote Viddler API field "clicking_through_enabled"
    /// </summary>
    [XmlElement(ElementName = "clicking_through_enabled")]
    public bool? ClickingThroughEnabled
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "email_this_enabled"
    /// </summary>
    [XmlElement(ElementName = "email_this_enabled")]
    public bool? EmailThisEnabled
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "trackbacks_enabled"
    /// </summary>
    [XmlElement(ElementName = "trackbacks_enabled")]
    public bool? TrackbacksEnabled
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "favorites"
    /// </summary>
    [XmlElement(ElementName = "favorites")]
    public bool? Favorites
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
  }
}
