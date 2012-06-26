using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class UserSession : DataObjectBase
  {
    /// <summary>
    /// Corresponds to the remote Viddler API field "sessionid"
    /// </summary>
    [XmlElement(ElementName = "sessionid")]
    public string SessionId
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "record_token"
    /// </summary>
    [XmlElement(ElementName = "record_token")]
    public string RecordToken
    {
      get;
      set;
    }
  }
}
