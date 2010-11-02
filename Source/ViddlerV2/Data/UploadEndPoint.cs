using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class UploadEndPoint : DataObjectBase
  {
    /// <summary>
    /// Corresponds to the remote Viddler API field "endpoint"
    /// </summary>
    [XmlElement(ElementName = "endpoint")]
    public string Url
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "token"
    /// </summary>
    [XmlElement(ElementName = "token")]
    public string Token
    {
      get;
      set;
    }
  }
}
