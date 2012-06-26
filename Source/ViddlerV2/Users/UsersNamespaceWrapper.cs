using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using Data = Viddler.Data;

namespace Viddler.Users
{
  /// <summary>
  /// Provides access to Viddler API methods located in viddler.users namespace.
  /// </summary>
  /// <remarks>Visit <a href="http://developers.viddler.com/" target="_blank">http://developers.viddler.com/</a> to get the full overview of methods contained in this class.</remarks>
  public sealed class UsersNamespaceWrapper : ViddlerNamespaceProvider
  {
    /// <summary>
    /// Initializes a new instance of UsersNamespaceWrapper class.
    /// </summary>
    internal UsersNamespaceWrapper(ViddlerService service) : base(service)
    {
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.users.auth
    /// </summary>
    public Data.UserSession Auth(string userName, string password, bool getRecordToken)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("user", userName);
      parameters.Add("password", password);
      parameters.Add("get_record_token", getRecordToken ? "1" : "0");

      Data.UserSession session = this.Service.ExecuteHttpRequest<Users.Auth, Data.UserSession>(parameters);
      if (session != null)
      {
        this.Service.SessionId = session.SessionId;
      }

      return session;
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.users.auth
    /// </summary>
    public Data.UserSession Auth(string userName, string password)
    {
      return this.Auth(userName, password, false);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.users.logout
    /// </summary>
    public bool LogOut()
    {
      ViddlerResponseSuccess responseObject = this.Service.ExecuteHttpRequest<Users.Logout, ViddlerResponseSuccess>(null);
      if (responseObject != null && responseObject.IsSuccess)
      {
        this.Service.SessionId = string.Empty;
        return true;
      }
      return false;
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.users.getProfile
    /// </summary>
    public Data.User GetProfile()
    {
      return this.GetProfile(null, false);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.users.getProfile
    /// </summary>
    public Data.User GetProfile(string userName)
    {
      return this.GetProfile(userName, false);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.users.getProfile
    /// </summary>
    public Data.User GetProfile(string userName, bool includeMetadata)
    {
      StringDictionary parameters = new StringDictionary();
      if (!string.IsNullOrEmpty(userName)) parameters.Add("user", userName);
      if (this.Service.IsAuthenticated) parameters.Add("sessionid", this.Service.SessionId);
      parameters.Add("include_metadata", includeMetadata ? "1" : "0");

      return this.Service.ExecuteHttpRequest<Users.GetProfile, Data.User>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.users.setProfile
    /// </summary>
    public Data.User SetProfile(string firstName, string lastName, string homePage, string email, string avatarUrl)
    {
      StringDictionary parameters = new StringDictionary();
      if (firstName != null) parameters.Add("first_name", firstName);
      if (lastName != null) parameters.Add("last_name", lastName);
      if (homePage != null) parameters.Add("homepage", homePage);
      if (!string.IsNullOrEmpty(email)) parameters.Add("email", email);
      if (avatarUrl != null) parameters.Add("avatar_url", avatarUrl);

      return this.Service.ExecuteHttpRequest<Users.SetProfile, Data.User>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.users.getStats
    /// </summary>
    public Data.Statistics GetStats()
    {
      return this.Service.ExecuteHttpRequest<Users.GetStats, Data.Statistics>(null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.users.register
    /// </summary>
    public Data.User Register(string userName, string password, bool termsAccepted, string email, string company, int? planId)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("user", userName);
      parameters.Add("password", password);
      parameters.Add("terms_accepted", termsAccepted ? "1" : "0");
      parameters.Add("email", email);
      if (!string.IsNullOrEmpty(company)) parameters.Add("company", company);
      if (planId.HasValue) parameters.Add("plan_id", planId.Value.ToString(CultureInfo.InvariantCulture));

      return this.Service.ExecuteHttpRequest<Users.Register, Data.User>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.users.getSettings
    /// </summary>
    public Data.UserSettings GetSettings()
    {
      return this.Service.ExecuteHttpRequest<Users.GetSettings, Data.UserSettings>(null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.users.setSettings
    /// </summary>
    public Data.UserSettings SetSettings(bool? visible, bool? gravatar, Data.PermissionLevel? defaultViewPermission,
      Data.PermissionLevel? defaultCommentPermission, Data.PermissionLevel? defaultDownloadPermission,
      Data.PermissionLevel? defaultEmbedPermission, Data.PermissionLevel? defaultTagPermission,
      string whitelistedDomains, bool? clickingThroughEnabled, bool? showRelatedVideos, bool? videoBrowserEnabled,
      bool? getLinkEnabled, int? embedCodeType, Data.VideoDeliveryMethod? videoDeliveryMethod, bool? hdPlayback, bool? mobilePlayback,
      string defaultVideoPermalink, string customEmbedUrl, Data.CommentsModerationLevel? commentsModeration, bool? emailEncodingEnd,
      bool? emailCommentReceived, bool? emailTagAdded, bool? emailCommentedVideoReceivedComment, bool? emailNewsletter)
    {
      StringDictionary parameters = new StringDictionary();
      if (visible.HasValue) parameters.Add("visible", visible.Value ? "1" : "0");
      if (gravatar.HasValue) parameters.Add("gravatar", gravatar.Value ? "1" : "0");
      if (defaultViewPermission.HasValue) parameters.Add("default_view_permission", ViddlerHelper.GetEnumName(defaultViewPermission.Value.GetType().GetField(defaultViewPermission.Value.ToString())));
      if (defaultCommentPermission.HasValue) parameters.Add("default_comment_permission", ViddlerHelper.GetEnumName(defaultCommentPermission.Value.GetType().GetField(defaultCommentPermission.Value.ToString())));
      if (defaultDownloadPermission.HasValue) parameters.Add("default_download_permission", ViddlerHelper.GetEnumName(defaultDownloadPermission.Value.GetType().GetField(defaultDownloadPermission.Value.ToString())));
      if (defaultEmbedPermission.HasValue) parameters.Add("default_embed_permission", ViddlerHelper.GetEnumName(defaultEmbedPermission.Value.GetType().GetField(defaultEmbedPermission.Value.ToString())));
      if (defaultTagPermission.HasValue) parameters.Add("default_tag_permission", ViddlerHelper.GetEnumName(defaultTagPermission.Value.GetType().GetField(defaultTagPermission.Value.ToString())));
      if (whitelistedDomains != null) parameters.Add("whitelisted_domains", whitelistedDomains);
      if (clickingThroughEnabled.HasValue) parameters.Add("clicking_through_enabled", clickingThroughEnabled.Value ? "1" : "0");
      if (showRelatedVideos.HasValue) parameters.Add("show_related_videos", showRelatedVideos.Value ? "1" : "0");
      if (videoBrowserEnabled.HasValue) parameters.Add("video_browser_enabled", videoBrowserEnabled.Value ? "1" : "0");
      if (getLinkEnabled.HasValue) parameters.Add("get_link_enabled", getLinkEnabled.Value ? "1" : "0");
      if (embedCodeType.HasValue) parameters.Add("embed_code_type", embedCodeType.Value.ToString(CultureInfo.InvariantCulture));
      if (videoDeliveryMethod.HasValue) parameters.Add("video_delivery_method", ViddlerHelper.GetEnumName(videoDeliveryMethod.Value.GetType().GetField(videoDeliveryMethod.Value.ToString())));
      if (hdPlayback.HasValue) parameters.Add("hd_playback", hdPlayback.Value ? "1" : "0");
      if (mobilePlayback.HasValue) parameters.Add("mobile_playback", mobilePlayback.Value ? "1" : "0");
      if (defaultVideoPermalink != null) parameters.Add("default_video_permalink", defaultVideoPermalink);
      if (customEmbedUrl != null) parameters.Add("custom_embed_url", customEmbedUrl);
      if (commentsModeration.HasValue) parameters.Add("comments_moderation", ViddlerHelper.GetEnumName(commentsModeration.Value.GetType().GetField(commentsModeration.Value.ToString())));
      if (emailEncodingEnd.HasValue) parameters.Add("email_encoding_end", emailEncodingEnd.Value ? "1" : "0");
      if (emailCommentReceived.HasValue) parameters.Add("email_comment_received", emailCommentReceived.Value ? "1" : "0");
      if (emailTagAdded.HasValue) parameters.Add("email_tag_added", emailTagAdded.Value ? "1" : "0");
      if (emailCommentedVideoReceivedComment.HasValue) parameters.Add("email_commented_video_received_comment", emailCommentedVideoReceivedComment.Value ? "1" : "0");
      if (emailNewsletter.HasValue) parameters.Add("email_newsletter", emailNewsletter.Value ? "1" : "0");

      return this.Service.ExecuteHttpRequest<Users.SetSettings, Data.UserSettings>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.users.getPlayerBranding
    /// </summary>
    public Data.PlayerBranding GetPlayerBranding()
    {
      return this.Service.ExecuteHttpRequest<Users.GetPlayerBranding, Data.PlayerBranding>(null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.users.setPlayerBranding
    /// </summary>
    public Data.PlayerBranding SetPlayerBranding(string logoUrl, string logoClickUrl, int? logoOffsetX, int? logoOffsetY,
      Data.ImageAlignmentType? logoAlign, bool? logoVisible, bool? shadeDark, bool? enableStirpes, string simpleColor,
      string controlBar, string bHover, string bIdle, string bClicked, string pIdle, string pHover, string pClicked,
      string timePlayed, string timeLoaded, string timeBackground)
    {
      StringDictionary parameters = new StringDictionary();
      if (logoUrl != null) parameters.Add("logo_url", logoUrl);
      if (logoClickUrl != null) parameters.Add("logo_click_url", logoClickUrl);
      if (logoOffsetX.HasValue) parameters.Add("logo_offset_x", logoOffsetX.Value.ToString(CultureInfo.InvariantCulture));
      if (logoOffsetY.HasValue) parameters.Add("logo_offset_y", logoOffsetY.Value.ToString(CultureInfo.InvariantCulture));
      if (logoAlign.HasValue) parameters.Add("logo_align", ViddlerHelper.GetEnumName(logoAlign.Value.GetType().GetField(logoAlign.Value.ToString())));
      if (logoVisible.HasValue) parameters.Add("logo_visible", logoVisible.Value.ToString(CultureInfo.InvariantCulture));
      if (shadeDark.HasValue) parameters.Add("shade_dark", shadeDark.Value.ToString(CultureInfo.InvariantCulture));
      if (enableStirpes.HasValue) parameters.Add("enable_stirpes", enableStirpes.Value.ToString(CultureInfo.InvariantCulture));
      if (!string.IsNullOrEmpty(simpleColor)) parameters.Add("simple_color", simpleColor);
      if (!string.IsNullOrEmpty(controlBar)) parameters.Add("control_bar", controlBar);
      if (!string.IsNullOrEmpty(bHover)) parameters.Add("bhover", bHover);
      if (!string.IsNullOrEmpty(bIdle)) parameters.Add("bidle", bIdle);
      if (!string.IsNullOrEmpty(bClicked)) parameters.Add("bclicked", bClicked);
      if (!string.IsNullOrEmpty(pIdle)) parameters.Add("pidle", pIdle);
      if (!string.IsNullOrEmpty(pHover)) parameters.Add("phover", pHover);
      if (!string.IsNullOrEmpty(pClicked)) parameters.Add("pclicked", pClicked);
      if (!string.IsNullOrEmpty(timePlayed)) parameters.Add("timeplayed", timePlayed);
      if (!string.IsNullOrEmpty(timeLoaded)) parameters.Add("timeloaded", timeLoaded);
      if (!string.IsNullOrEmpty(timeBackground)) parameters.Add("timebackground", timeBackground);

      return this.Service.ExecuteHttpRequest<Users.SetPlayerBranding, Data.PlayerBranding>(parameters);
    }
  }
}