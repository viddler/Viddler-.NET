using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class EchoMessage : DataObjectBase
  {
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
