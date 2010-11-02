using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class Playlist : DataObjectBase
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
    /// Corresponds to the remote Viddler API field "name"
    /// </summary>
    [XmlElement(ElementName = "name")]
    public string Name
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "type"
    /// </summary>
    [XmlElement(ElementName = "type")]
    public PlaylistType? Type
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "visibility"
    /// </summary>
    [XmlElement(ElementName = "visibility")]
    public PlaylistVisibilityType? Visibility
    {
      get;
      set;
    }
  }
}
