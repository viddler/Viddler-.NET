using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class PendingPlan : DataObjectBase
  {
    /// <summary>
    /// Corresponds to the remote Viddler API field "started_at"
    /// </summary>
    [XmlElement(ElementName = "started_at")]
    public UnixTimeStamp? StartedAt
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "update_date"
    /// </summary>
    [XmlElement(ElementName = "update_date")]
    public UnixTimeStamp? UpdateDate
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "plan"
    /// </summary>
    [XmlElement(ElementName = "plan")]
    public UserPlan Plan
    {
      get;
      set;
    }
  }
}
