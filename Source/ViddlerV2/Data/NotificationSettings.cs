using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class NotificationSettings : DataObjectBase
  {
    /// <summary>
    /// Corresponds to the remote Viddler API field "email_encoding_end"
    /// </summary>
    [XmlElement(ElementName = "email_encoding_end")]
    public bool? EmailEncodingEnd
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "email_comment_received"
    /// </summary>
    [XmlElement(ElementName = "email_comment_received")]
    public bool? EmailCommentReceived
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "email_tag_added"
    /// </summary>
    [XmlElement(ElementName = "email_tag_added")]
    public bool? EmailTagAdded
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "email_commented_video_received_comment"
    /// </summary>
    [XmlElement(ElementName = "email_commented_video_received_comment")]
    public bool? EmailCommentedVideoReceivedComment
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "email_newsletter"
    /// </summary>
    [XmlElement(ElementName = "email_newsletter")]
    public bool? EmailNewsletter
    {
      get;
      set;
    }
  }
}
