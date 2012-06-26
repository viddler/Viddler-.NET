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
  public class SubaccountPlan : DataObjectBase
  {
    /// <summary>
    /// Corresponds to the remote Viddler API field "id"
    /// </summary>
    [XmlElement(ElementName = "id")]
    public string Id
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "name"
    /// </summary>
    [XmlElement(ElementName = "name")]
    public string Name
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "payment_plan"
    /// </summary>
    [XmlElement(ElementName = "payment_plan")]
    public string PaymentPlan
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "payment_plan_id"
    /// </summary>
    [XmlElement(ElementName = "payment_plan_id")]
    public int? PaymentPlanId
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "plan_minimum"
    /// </summary>
    [XmlElement(ElementName = "plan_minimum")]
    public double? PlanMinimum
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "subaccount_addons_discount"
    /// </summary>
    [XmlElement(ElementName = "subaccount_addons_discount")]
    public double? SubaccountAddonsDiscount
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "subaccount_price"
    /// </summary>
    [XmlElement(ElementName = "subaccount_price")]
    public double? SubaccountPrice
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "bandwidth"
    /// </summary>
    [XmlElement(ElementName = "bandwidth")]
    public long? Bandwidth
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "storage"
    /// </summary>
    [XmlElement(ElementName = "storage")]
    public long? Storage
    {
      get;
      set;
    }
  }
}
