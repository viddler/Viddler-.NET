using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class CommentsModeration : DataObjectBase
  {
    /// <summary>
    /// Corresponds to the remote Viddler API field "status"
    /// </summary>
    [XmlElement(ElementName = "status")]
    public CommentsModerationStatus? Status
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "obscenity_filter"
    /// </summary>
    [XmlElement(ElementName = "obscenity_filter")]
    public string ObscenityFilter
    {
      get;
      set;
    }
  }
}
