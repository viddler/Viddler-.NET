using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class ApiInfo : DataObjectBase
  {
    /// <summary>
    /// Corresponds to the remote Viddler API field "version"
    /// </summary>
    [XmlElement(ElementName = "version")]
    public string Version
    {
      get;
      set;
    }
  }
}
