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
  public class User : DataObjectBase
  {
    /// <summary>
    /// Initializes a new instance of data object class.
    /// </summary>
    public User()
    {
      this.Subaccounts = new List<Subaccount>();
      this.Metadata = new List<Metadata>();
    }

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
    /// Corresponds to the remote Viddler API field "first_name"
    /// </summary>
    [XmlElement(ElementName = "first_name")]
    public string FirstName
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "last_name"
    /// </summary>
    [XmlElement(ElementName = "last_name")]
    public string LastName
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "homepage"
    /// </summary>
    [XmlElement(ElementName = "homepage")]
    public string HomePage
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "email"
    /// </summary>
    [XmlElement(ElementName = "email")]
    public string Email
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "avatar"
    /// </summary>
    [XmlElement(ElementName = "avatar")]
    public string Avatar
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "video_upload_count"
    /// </summary>
    [XmlElement(ElementName = "video_upload_count")]
    public int? VideoUploadCount
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "video_watch_count"
    /// </summary>
    [XmlElement(ElementName = "video_watch_count")]
    public int? VideoWatchCount
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "visible"
    /// </summary>
    [XmlElement(ElementName = "visible")]
    public bool? Visible
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "expires_at"
    /// </summary>
    [XmlElement(ElementName = "expires_at")]
    public UnixTimeStamp? ExpiresAt
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "status"
    /// </summary>
    [XmlElement(ElementName = "status")]
    public UserStatus? Status
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "parent"
    /// </summary>
    [XmlElement(ElementName = "parent")]
    public string Parent
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "reseller"
    /// </summary>
    [XmlElement(ElementName = "reseller")]
    public ResellerStatus? Reseller
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "admin"
    /// </summary>
    [XmlElement(ElementName = "admin")]
    public bool? Admin
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "staff"
    /// </summary>
    [XmlElement(ElementName = "staff")]
    public bool? Staff
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "force_redirect"
    /// </summary>
    [XmlElement(ElementName = "force_redirect")]
    public string ForceRedirect
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "force_redirect_code"
    /// </summary>
    [XmlElement(ElementName = "force_redirect_code")]
    public int? ForceRedirectCode
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "subaccounts"
    /// </summary>
    [XmlArray(ElementName = "subaccounts")]
    [XmlArrayItem(ElementName = "subaccount")]
    public List<Subaccount> Subaccounts
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "metadata_list"
    /// </summary>
    [XmlArray(ElementName = "metadata_list")]
    [XmlArrayItem(ElementName = "metadata")]
    public List<Metadata> Metadata
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "itunes_settings"
    /// </summary>
    [XmlElement(ElementName = "itunes_settings")]
    public ITunesSettings ITunes
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "settings"
    /// </summary>
    [XmlElement(ElementName = "settings")]
    public UserSettings Settings
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "payment_setup"
    /// </summary>
    [XmlElement(ElementName = "payment_setup")]
    public PaymentSetup PaymentSetup
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

    /// <summary>
    /// Corresponds to the remote Viddler API field "pending_plan_change"
    /// </summary>
    [XmlElement(ElementName = "pending_plan_change")]
    public PendingPlan PendingPlanChange
    {
      get;
      set;
    }
  }
}
