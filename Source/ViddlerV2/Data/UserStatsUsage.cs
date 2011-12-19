using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class UserStatsUsage : DataObjectBase
  {
    /// <summary>
    /// Corresponds to the remote Viddler API field "storage"
    /// </summary>
    [XmlElement(ElementName = "storage")]
    public Int64? Storage
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "bandwidth"
    /// </summary>
    [XmlElement(ElementName = "bandwidth")]
    public Int64? Bandwidth
    {
      get;
      set;
    }
  }
}
