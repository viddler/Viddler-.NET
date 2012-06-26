using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class PaymentSetup : DataObjectBase
  {
    /// <summary>
    /// Corresponds to the remote Viddler API field "invoicing"
    /// </summary>
    [XmlElement(ElementName = "invoicing")]
    public bool? Invoicing
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "payment_type"
    /// </summary>
    [XmlElement(ElementName = "payment_type")]
    public PaymentType? PaymentType
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "company"
    /// </summary>
    [XmlElement(ElementName = "company")]
    public string Company
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "phone"
    /// </summary>
    [XmlElement(ElementName = "phone")]
    public string Phone
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "country"
    /// </summary>
    [XmlElement(ElementName = "country")]
    public string Country
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "city"
    /// </summary>
    [XmlElement(ElementName = "city")]
    public string City
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "address_1"
    /// </summary>
    [XmlElement(ElementName = "address_1")]
    public string Address1
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "address_2"
    /// </summary>
    [XmlElement(ElementName = "address_2")]
    public string Address2
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "zipcode"
    /// </summary>
    [XmlElement(ElementName = "zipcode")]
    public string ZipCode
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "state"
    /// </summary>
    [XmlElement(ElementName = "state")]
    public string State
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "cc_type"
    /// </summary>
    [XmlElement(ElementName = "cc_type")]
    public string CcType
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "cc_month"
    /// </summary>
    [XmlElement(ElementName = "cc_month")]
    public int? CcMonth
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "cc_year"
    /// </summary>
    [XmlElement(ElementName = "cc_year")]
    public int? CcYear
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "credit_valid"
    /// </summary>
    [XmlElement(ElementName = "credit_valid")]
    public bool? CreditValid
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "last_processing"
    /// </summary>
    [XmlElement(ElementName = "last_processing")]
    public UnixTimeStamp? LastProcessing
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "paid_till"
    /// </summary>
    [XmlElement(ElementName = "paid_till")]
    public UnixTimeStamp? PaidTill
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "days_till_next_processing"
    /// </summary>
    [XmlElement(ElementName = "days_till_next_processing")]
    public int? DaysTillNextProcessing
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "days_in_current_billing_cycle"
    /// </summary>
    [XmlElement(ElementName = "days_in_current_billing_cycle")]
    public int? DaysInCurrentBillingCycle
    {
      get;
      set;
    }
  }
}
