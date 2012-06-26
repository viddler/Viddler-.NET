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
  public class UserPlan : DataObjectBase
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
    /// Corresponds to the remote Viddler API field "salesforce_name"
    /// </summary>
    [XmlElement(ElementName = "salesforce_name")]
    public string SalesforceName
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "code"
    /// </summary>
    [XmlElement(ElementName = "code")]
    public string Code
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "sellable"
    /// </summary>
    [XmlElement(ElementName = "sellable")]
    public bool? Sellable
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "status"
    /// </summary>
    [XmlElement(ElementName = "status")]
    public bool? Status
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "type"
    /// </summary>
    [XmlElement(ElementName = "type")]
    public string Type
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "current"
    /// </summary>
    [XmlElement(ElementName = "current")]
    public bool? Current
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "delete_protection"
    /// </summary>
    [XmlElement(ElementName = "delete_protection")]
    public bool? DeleteProtection
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "analytics"
    /// </summary>
    [XmlElement(ElementName = "analytics")]
    public bool? Analytics
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "itunes"
    /// </summary>
    [XmlElement(ElementName = "itunes")]
    public bool? ITunes
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "miro"
    /// </summary>
    [XmlElement(ElementName = "miro")]
    public bool? Miro
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "max_account_life"
    /// </summary>
    [XmlElement(ElementName = "max_account_life")]
    public int? MaxAccountLife
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "subaccount"
    /// </summary>
    [XmlElement(ElementName = "subaccount")]
    public bool? Subaccount
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "flash"
    /// </summary>
    [XmlElement(ElementName = "flash")]
    public bool? Flash
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "visibility"
    /// </summary>
    [XmlElement(ElementName = "visibility")]
    public bool? Visibility
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "business_agreement"
    /// </summary>
    [XmlElement(ElementName = "business_agreement")]
    public bool? BusinessAgreement
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "max_api_keys"
    /// </summary>
    [XmlElement(ElementName = "max_api_keys")]
    public int? MaxApiKeys
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "api"
    /// </summary>
    [XmlElement(ElementName = "api")]
    public bool? Api
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "spam_trusted"
    /// </summary>
    [XmlElement(ElementName = "spam_trusted")]
    public bool? SpamTrusted
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "comscore"
    /// </summary>
    [XmlElement(ElementName = "comscore")]
    public bool? Comscore
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "subscriptions"
    /// </summary>
    [XmlElement(ElementName = "subscriptions")]
    public bool? Subscriptions
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "contests"
    /// </summary>
    [XmlElement(ElementName = "contests")]
    public bool? Contests
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "vidgets"
    /// </summary>
    [XmlElement(ElementName = "vidgets")]
    public bool? Vidgets
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "private_viewer"
    /// </summary>
    [XmlElement(ElementName = "private_viewer")]
    public bool? PrivateViewer
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "ftp"
    /// </summary>
    [XmlElement(ElementName = "ftp")]
    public bool? Ftp
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "upload_size_limit"
    /// </summary>
    [XmlElement(ElementName = "upload_size_limit")]
    public long? UploadSizeLimit
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "videos_limit"
    /// </summary>
    [XmlElement(ElementName = "videos_limit")]
    public int? VideosLimit
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "max_uploads_per_week"
    /// </summary>
    [XmlElement(ElementName = "max_uploads_per_week")]
    public int? MaxUploadsPerWeek
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "max_upload_video_length"
    /// </summary>
    [XmlElement(ElementName = "max_upload_video_length")]
    public int? MaxUploadVideoLength
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "encoding_backprocess"
    /// </summary>
    [XmlElement(ElementName = "encoding_backprocess")]
    public bool? EncodingBackprocess
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "use_source_for_playback"
    /// </summary>
    [XmlElement(ElementName = "use_source_for_playback")]
    public bool? UseSourceForPlayback
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "preserve_sources"
    /// </summary>
    [XmlElement(ElementName = "preserve_sources")]
    public bool? PreserveSources
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "profiles"
    /// </summary>
    [XmlArray(ElementName = "encoding_profiles")]
    [XmlArrayItem(ElementName = "profile")]
    public List<EncodingProfile> Items
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "edgecast"
    /// </summary>
    [XmlElement(ElementName = "edgecast")]
    public bool? Edgecast
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "throtling"
    /// </summary>
    [XmlElement(ElementName = "throtling")]
    public bool? Throtling
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "monitor_for_overages"
    /// </summary>
    [XmlElement(ElementName = "monitor_for_overages")]
    public bool? MonitorForOverages
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "player_branding"
    /// </summary>
    [XmlElement(ElementName = "player_branding")]
    public bool? PlayerBranding
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "custom_logo"
    /// </summary>
    [XmlElement(ElementName = "custom_logo")]
    public bool? CustomLogo
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "logo_visibility"
    /// </summary>
    [XmlElement(ElementName = "logo_visibility")]
    public bool? LogoVisibility
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "https"
    /// </summary>
    [XmlElement(ElementName = "https")]
    public bool? Https
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "private_embedding"
    /// </summary>
    [XmlElement(ElementName = "private_embedding")]
    public bool? PrivateEmbedding
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "permalinks"
    /// </summary>
    [XmlElement(ElementName = "permalinks")]
    public bool? Permalinks
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "custom_embed_url"
    /// </summary>
    [XmlElement(ElementName = "custom_embed_url")]
    public bool? CustomEmbedUrl
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "embed_codes"
    /// </summary>
    [XmlElement(ElementName = "embed_codes")]
    public bool? EmbedCodes
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "postroll"
    /// </summary>
    [XmlElement(ElementName = "postroll")]
    public bool? Postroll
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "max_tags_per_video"
    /// </summary>
    [XmlElement(ElementName = "max_tags_per_video")]
    public int? MaxTagsPerVideo
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "commenting"
    /// </summary>
    [XmlElement(ElementName = "commenting")]
    public bool? Commenting
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "comments_moderation_enabled"
    /// </summary>
    [XmlElement(ElementName = "comments_moderation_enabled")]
    public bool? CommentsModerationEnabled
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "comments_moderation_level"
    /// </summary>
    [XmlElement(ElementName = "comments_moderation_level")]
    public CommentsModerationLevel? CommentsModerationLevel
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "player_signup"
    /// </summary>
    [XmlElement(ElementName = "player_signup")]
    public bool? PlayerSignup
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "age_gate"
    /// </summary>
    [XmlElement(ElementName = "age_gate")]
    public bool? AgeGate
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "download"
    /// </summary>
    [XmlElement(ElementName = "download")]
    public bool? Download
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "domain_whitelisting"
    /// </summary>
    [XmlElement(ElementName = "domain_whitelisting")]
    public bool? DomainWhitelisting
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "tagging"
    /// </summary>
    [XmlElement(ElementName = "tagging")]
    public bool? Tagging
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "video_commenting"
    /// </summary>
    [XmlElement(ElementName = "video_commenting")]
    public bool? VideoCommenting
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "own_videos_ads"
    /// </summary>
    [XmlElement(ElementName = "own_videos_ads")]
    public bool? OwnVideosAds
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "disable_ads_when_logged_in"
    /// </summary>
    [XmlElement(ElementName = "disable_ads_when_logged_in")]
    public bool? DisableAdsWhenLoggedIn
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "liverail"
    /// </summary>
    [XmlElement(ElementName = "liverail")]
    public bool? Liverail
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "lightningcast"
    /// </summary>
    [XmlElement(ElementName = "lightningcast")]
    public bool? Lightningcast
    {
      get;
      set;
    }

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
    /// Corresponds to the remote Viddler API field "payment_plan"
    /// </summary>
    [XmlElement(ElementName = "payment_plan")]
    public string PaymentPlan
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
    /// Corresponds to the remote Viddler API field "zendesk_support"
    /// </summary>
    [XmlElement(ElementName = "zendesk_support")]
    public bool? ZendeskSupport
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "forum_support"
    /// </summary>
    [XmlElement(ElementName = "forum_support")]
    public bool? ForumSupport
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "email_support"
    /// </summary>
    [XmlElement(ElementName = "email_support")]
    public bool? EmailSupport
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "phone_support"
    /// </summary>
    [XmlElement(ElementName = "phone_support")]
    public bool? PhoneSupport
    {
      get;
      set;
    }
  }
}
