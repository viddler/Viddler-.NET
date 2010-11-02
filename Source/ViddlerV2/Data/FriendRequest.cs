using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class FriendRequest : DataObjectBase
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
    /// Corresponds to the remote Viddler API field "user"
    /// </summary>
    [XmlElement(ElementName = "user")]
    public string UserName
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "date"
    /// </summary>
    [XmlElement(ElementName = "date")]
    public UnixTimeStamp? Date
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "message"
    /// </summary>
    [XmlElement(ElementName = "message")]
    public string Message
    {
      get;
      set;
    }
  }
}
