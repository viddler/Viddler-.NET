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
    internal UsersNamespaceWrapper(ViddlerService service)
      : base(service)
    {
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.users.auth
    /// </summary>
    public Data.UserSession Auth(string userName, string password)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("user", userName);
      parameters.Add("password", password);

      Data.UserSession session = this.Service.ExecuteHttpRequest<Users.Auth, Data.UserSession>(parameters);
      if (session != null)
      {
        this.Service.SessionId = session.SessionId;
      }

      return session;
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.users.search
    /// </summary>
    public Data.UserList Search(string query)
    {
      return this.Search(query, null, null, null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.users.search
    /// </summary>
    public Data.UserList Search(string query, Data.UserListType? type)
    {
      return this.Search(query, type, null, null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.users.search
    /// </summary>
    public Data.UserList Search(string query, Data.UserListType? type, int? page, int? perPage)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("query", query ?? string.Empty);
      if (type.HasValue) parameters.Add("type", ViddlerHelper.GetEnumName(type.Value.GetType().GetField(type.Value.ToString())));
      if (page.HasValue) parameters.Add("page", page.Value.ToString(CultureInfo.InvariantCulture));
      if (perPage.HasValue) parameters.Add("per_page", perPage.Value.ToString(CultureInfo.InvariantCulture));

      return this.Service.ExecuteHttpRequest<Users.Search, Data.UserList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.users.getProfile
    /// </summary>
    public Data.User GetProfile(string userName)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("user", userName);

      return this.Service.ExecuteHttpRequest<Users.GetProfile, Data.User>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.users.getStats
    /// </summary>
    public Data.UserStats GetStats()
    {
      return this.Service.ExecuteHttpRequest<Users.GetStats, Data.UserStats>(null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.users.setProfile
    /// </summary>
    public Data.User SetProfile(string firstName, string lastName, Data.UserGender? gender, string city, string company, string aboutMe)
    {
      return this.SetProfile(firstName, lastName, gender, city, company, aboutMe, DateTime.MinValue);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.users.setProfile
    /// </summary>
    public Data.User SetProfile(string firstName, string lastName, Data.UserGender? gender, string city, string company, string aboutMe, DateTime? birthDate)
    {
      StringDictionary parameters = new StringDictionary();
      if (firstName != null) parameters.Add("first_name", firstName);
      if (lastName != null) parameters.Add("last_name", lastName);
      if (aboutMe != null) parameters.Add("about_me", aboutMe);
      if (gender.HasValue) parameters.Add("gender", ViddlerHelper.GetEnumName(gender.Value.GetType().GetField(gender.Value.ToString())));
      if (company != null) parameters.Add("company", company);
      if (city != null) parameters.Add("city", city);
      if (birthDate.HasValue) parameters.Add("birthdate", birthDate.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));

      return this.Service.ExecuteHttpRequest<Users.SetProfile, Data.User>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.users.getFriends
    /// </summary>
    public Data.Friends GetFriends()
    {
      return this.Service.ExecuteHttpRequest<Users.GetFriends, Data.Friends>(null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.users.sendFriendRequest
    /// </summary>
    public bool SendFriendRequest(string userName, string message)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("user", userName);
      parameters.Add("message", message);

      ViddlerResponseSuccess responseObject = this.Service.ExecuteHttpRequest<Users.SendFriendRequest, ViddlerResponseSuccess>(parameters);
      return (responseObject != null && responseObject.IsSuccess);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.users.removeFriend
    /// </summary>
    public Data.Friends RemoveFriend(string userName)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("user", userName);

      return this.Service.ExecuteHttpRequest<Users.RemoveFriend, Data.Friends>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.users.getFriendRequests
    /// </summary>
    public Data.FriendRequestList GetFriendRequests()
    {
      return this.Service.ExecuteHttpRequest<Users.GetFriendRequests, Data.FriendRequestList>(null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.users.acceptFriendRequest
    /// </summary>
    public Data.FriendRequestList AcceptFriendRequest(string requestId)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("friend_request_id", requestId);

      return this.Service.ExecuteHttpRequest<Users.AcceptFriendRequest, Data.FriendRequestList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.users.ignoreFriendRequest
    /// </summary>
    public Data.FriendRequestList IgnoreFriendRequest(string requestId)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("friend_request_id", requestId);

      return this.Service.ExecuteHttpRequest<Users.IgnoreFriendRequest, Data.FriendRequestList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.users.getSettings
    /// </summary>
    public Data.UserSettings GetSettings()
    {
      return this.Service.ExecuteHttpRequest<Users.GetSettings, Data.UserSettings>(null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.users.getSubscribed
    /// </summary>
    public Data.SubscribedList GetSubscribed(int? page, int? perPage)
    {
      StringDictionary parameters = new StringDictionary();
      if (page.HasValue) parameters.Add("page", page.Value.ToString(CultureInfo.InvariantCulture));
      if (perPage.HasValue) parameters.Add("per_page", perPage.Value.ToString(CultureInfo.InvariantCulture));

      return this.Service.ExecuteHttpRequest<Users.GetSubscribed, Data.SubscribedList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.users.getSubscribed
    /// </summary>
    public Data.SubscribedList GetSubscribed()
    {
      return this.GetSubscribed(null, null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.users.subscribe
    /// </summary>
    public Data.SubscribedList Subscribe(string userName)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("user", userName);

      return this.Service.ExecuteHttpRequest<Users.Subscribe, Data.SubscribedList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.users.unsubscribe
    /// </summary>
    public Data.SubscribedList Unsubscribe(string userName)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("user", userName);

      return this.Service.ExecuteHttpRequest<Users.Unsubscribe, Data.SubscribedList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.users.register
    /// </summary>
    public Data.User Register(string userName, string password, bool termsAccepted, string email, string firstName, string lastName, string company)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("user", userName);
      parameters.Add("password", password);
      parameters.Add("termsaccepted", termsAccepted ? "1" : "0");
      parameters.Add("email", email);
      parameters.Add("fname", firstName);
      parameters.Add("lname", lastName);
      if (!string.IsNullOrEmpty(company)) parameters.Add("company", company);

      return this.Service.ExecuteHttpRequest<Users.Register, Data.User>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.users.setSettings
    /// </summary>
    public Data.UserSettings SetSettings(bool? showAccount, bool? taggingEnabled, bool? commentingEnabled,
      bool? showRelatedVideos, bool? embeddingEnabled, bool? clickingThroughEnabled, bool? emailThisEnabled,
      bool? trackbacksEnabled, bool? favorites, int? embedCodeType)
    {
      StringDictionary parameters = new StringDictionary();
      if (showAccount.HasValue) parameters.Add("show_account", showAccount.Value ? "1" : "0");
      if (taggingEnabled.HasValue) parameters.Add("tagging_enabled", taggingEnabled.Value ? "1" : "0");
      if (commentingEnabled.HasValue) parameters.Add("commenting_enabled", commentingEnabled.Value ? "1" : "0");
      if (showRelatedVideos.HasValue) parameters.Add("show_related_videos", showRelatedVideos.Value ? "1" : "0");
      if (embeddingEnabled.HasValue) parameters.Add("embedding_enabled", embeddingEnabled.Value ? "1" : "0");
      if (clickingThroughEnabled.HasValue) parameters.Add("clicking_through_enabled", clickingThroughEnabled.Value ? "1" : "0");
      if (emailThisEnabled.HasValue) parameters.Add("email_this_enabled", emailThisEnabled.Value ? "1" : "0");
      if (trackbacksEnabled.HasValue) parameters.Add("trackbacks_enabled", trackbacksEnabled.Value ? "1" : "0");
      if (favorites.HasValue) parameters.Add("favorites", favorites.Value ? "1" : "0");
      if (embedCodeType.HasValue) parameters.Add("embed_code_type", embedCodeType.Value.ToString(CultureInfo.InvariantCulture));

      return this.Service.ExecuteHttpRequest<Users.SetSettings, Data.UserSettings>(parameters);
    }
  }
}
