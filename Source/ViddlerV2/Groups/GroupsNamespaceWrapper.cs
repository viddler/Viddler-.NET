using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using Data = Viddler.Data;

namespace Viddler.Groups
{
  /// <summary>
  /// Provides access to Viddler API methods located in viddler.groups namespace.
  /// </summary>
  /// <remarks>Visit <a href="http://developers.viddler.com/" target="_blank">http://developers.viddler.com/</a> to get the full overview of methods contained in this class.</remarks>
  public sealed class GroupsNamespaceWrapper : ViddlerNamespaceProvider
  {
    /// <summary>
    /// Initializes a new instance of GroupsNamespaceWrapper class.
    /// </summary>
    internal GroupsNamespaceWrapper(ViddlerService service)
      : base(service)
    {
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.groups.getByUser
    /// </summary>
    public Data.GroupList GetByUser(string userName, int? page, int? perPage)
    {
      StringDictionary parameters = new StringDictionary();
      if (page.HasValue) parameters.Add("page", page.Value.ToString(CultureInfo.InvariantCulture));
      if (perPage.HasValue) parameters.Add("per_page", perPage.Value.ToString(CultureInfo.InvariantCulture));
      if (this.Service.IsAuthenticated)
      {
        parameters.Add("sessionid", this.Service.SessionId);
      }
      else if (!string.IsNullOrEmpty(userName))
      {
        parameters.Add("user", userName);
      }

      return this.Service.ExecuteHttpRequest<Groups.GetByUser, Data.GroupList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.groups.getByUser
    /// </summary>
    public Data.GroupList GetByUser(int? page, int? perPage)
    {
      return this.GetByUser(null, page, perPage);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.groups.getByUser
    /// </summary>
    public Data.GroupList GetByUser()
    {
      return this.GetByUser(null, null, null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.groups.getByTag
    /// </summary>
    public Data.GroupList GetByTag(string tag, int? page, int? perPage)
    {
      StringDictionary parameters = new StringDictionary();
      if (page.HasValue) parameters.Add("page", page.Value.ToString(CultureInfo.InvariantCulture));
      if (perPage.HasValue) parameters.Add("per_page", perPage.Value.ToString(CultureInfo.InvariantCulture));
      parameters.Add("tag", tag);

      return this.Service.ExecuteHttpRequest<Groups.GetByTag, Data.GroupList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.groups.getByTag
    /// </summary>
    public Data.GroupList GetByTag(string tag)
    {
      return this.GetByTag(tag, null, null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.groups.getByVideo
    /// </summary>
    public Data.GroupList GetByVideo(string videoId, int? page, int? perPage)
    {
      StringDictionary parameters = new StringDictionary();
      if (page.HasValue) parameters.Add("page", page.Value.ToString(CultureInfo.InvariantCulture));
      if (perPage.HasValue) parameters.Add("per_page", perPage.Value.ToString(CultureInfo.InvariantCulture));
      parameters.Add("video_id", videoId);

      return this.Service.ExecuteHttpRequest<Groups.GetByVideo, Data.GroupList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.groups.getByTag
    /// </summary>
    public Data.GroupList GetByVideo(string tag)
    {
      return this.GetByVideo(tag, null, null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.groups.getVideos
    /// </summary>
    public Data.GroupVideoList GetVideos(string groupId, int? page, int? perPage)
    {
      StringDictionary parameters = new StringDictionary();
      if (page.HasValue) parameters.Add("page", page.Value.ToString(CultureInfo.InvariantCulture));
      if (perPage.HasValue) parameters.Add("per_page", perPage.Value.ToString(CultureInfo.InvariantCulture));
      parameters.Add("group_id", groupId);

      return this.Service.ExecuteHttpRequest<Groups.GetVideos, Data.GroupVideoList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.groups.getVideos
    /// </summary>
    public Data.GroupVideoList GetVideos(string groupId)
    {
      return this.GetVideos(groupId, null, null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.groups.addVideo
    /// </summary>
    public Data.GroupVideoList AddVideo(string groupId, string videoId)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("group_id", groupId);
      parameters.Add("video_id", videoId);

      return this.Service.ExecuteHttpRequest<Groups.AddVideo, Data.GroupVideoList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.groups.removeVideo
    /// </summary>
    public Data.GroupVideoList RemoveVideo(string groupId, string videoId)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("group_id", groupId);
      parameters.Add("video_id", videoId);

      return this.Service.ExecuteHttpRequest<Groups.RemoveVideo, Data.GroupVideoList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.groups.join
    /// </summary>
    public Data.GroupList Join(string groupId)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("group_id", groupId);

      return this.Service.ExecuteHttpRequest<Groups.Join, Data.GroupList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.groups.leave
    /// </summary>
    public Data.GroupList Leave(string groupId)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("group_id", groupId);

      return this.Service.ExecuteHttpRequest<Groups.Leave, Data.GroupList>(parameters);
    }
  }
}
