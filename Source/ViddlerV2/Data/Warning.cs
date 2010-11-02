using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class Warning
  {
    /// <summary>
    /// Corresponds to the remote Viddler API field "description"
    /// </summary>
    [XmlElement(ElementName = "description")]
    public string Description
    {
      get;
      set;
    }
  }
}
