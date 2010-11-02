using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class RecordToken : DataObjectBase
  {
    /// <summary>
    /// Corresponds to the remote Viddler API field "value"
    /// </summary>
    [XmlElement(ElementName = "value")]
    public string Value
    {
      get;
      set;
    }
  }
}
