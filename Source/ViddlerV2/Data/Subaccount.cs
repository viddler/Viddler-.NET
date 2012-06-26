using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class Subaccount : DataObjectBase
  {
    /// <summary>
    /// Corresponds to the remote Viddler API field "username"
    /// </summary>
    [XmlElement(ElementName = "username")]
    public string UserName
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "plan"
    /// </summary>
    [XmlElement(ElementName = "plan")]
    public SubaccountPlan Plan
    {
      get;
      set;
    }
  }
}
