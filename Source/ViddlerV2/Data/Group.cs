using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class Group : DataObjectBase
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
    /// Corresponds to the remote Viddler API field "created_at"
    /// </summary>
    [XmlElement(ElementName = "created_at")]
    public UnixTimeStamp? CreatedAt
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "created_by"
    /// </summary>
    [XmlElement(ElementName = "created_by")]
    public string CreatedBy
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
    /// Corresponds to the remote Viddler API field "description"
    /// </summary>
    [XmlElement(ElementName = "description")]
    public string Description
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "tags"
    /// </summary>
    [XmlElement(ElementName = "tags")]
    public string Tags
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
    /// Corresponds to the remote Viddler API field "members"
    /// </summary>
    [XmlElement(ElementName = "members")]
    public int? Members
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "videos"
    /// </summary>
    [XmlElement(ElementName = "videos")]
    public int? Videos
    {
      get;
      set;
    }
  }
}
