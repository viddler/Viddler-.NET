using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class LiverailSettings : DataObjectBase
  {
    /// <summary>
    /// Corresponds to the remote Viddler API field "manageable"
    /// </summary>
    [XmlElement(ElementName = "manageable")]
    public bool? Manageable
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "enabled"
    /// </summary>
    [XmlElement(ElementName = "enabled")]
    public bool? Enabled
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "id"
    /// </summary>
    [XmlElement(ElementName = "id")]
    public int? Id
    {
      get;
      set;
    }
  }
}
