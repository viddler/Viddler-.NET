using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class CommentsModerationSettings : DataObjectBase
  {
    /// <summary>
    /// Corresponds to the remote Viddler API field "status"
    /// </summary>
    [XmlElement(ElementName = "status")]
    public bool? Status
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "level"
    /// </summary>
    [XmlElement(ElementName = "level")]
    public CommentsModerationLevel? Level
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "to_review"
    /// </summary>
    [XmlElement(ElementName = "to_review")]
    public int? ToReview
    {
      get;
      set;
    }
  }
}
