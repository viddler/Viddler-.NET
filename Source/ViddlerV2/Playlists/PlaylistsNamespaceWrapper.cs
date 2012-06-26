using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using Data = Viddler.Data;

namespace Viddler.Playlists
{
  /// <summary>
  /// Provides access to Viddler API methods located in viddler.playlists namespace.
  /// </summary>
  /// <remarks>Visit <a href="http://developers.viddler.com/" target="_blank">http://developers.viddler.com/</a> to get the full overview of methods contained in this class.</remarks>
  public sealed class PlaylistsNamespaceWrapper : ViddlerNamespaceProvider
  {
    /// <summary>
    /// Initializes a new instance of PlaylistsNamespaceWrapper class.
    /// </summary>
    internal PlaylistsNamespaceWrapper(ViddlerService service) : base(service)
    {
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.playlists.getDetails
    /// </summary>
    public Data.PlaylistVideoList GetDetails(string playlistId, int? page, int? perPage)
    {
      StringDictionary parameters = new StringDictionary();
      if (page.HasValue) parameters.Add("page", page.Value.ToString(CultureInfo.InvariantCulture));
      if (perPage.HasValue) parameters.Add("per_page", perPage.Value.ToString(CultureInfo.InvariantCulture));
      parameters.Add("playlist_id", playlistId);

      return this.Service.ExecuteHttpRequest<Playlists.GetDetails, Data.PlaylistVideoList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.playlists.getDetails
    /// </summary>
    public Data.PlaylistVideoList GetDetails(string playlistId)
    {
      return this.GetDetails(playlistId, null, null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.playlists.getByUser
    /// </summary>
    public Data.PlaylistList GetByUser(string userName, int? page, int? perPage)
    {
      StringDictionary parameters = new StringDictionary();
      if (page.HasValue) parameters.Add("page", page.Value.ToString(CultureInfo.InvariantCulture));
      if (perPage.HasValue) parameters.Add("per_page", perPage.Value.ToString(CultureInfo.InvariantCulture));
      if (this.Service.IsAuthenticated) parameters.Add("sessionid", this.Service.SessionId);
      if (!string.IsNullOrEmpty(userName)) parameters.Add("user", userName);

      return this.Service.ExecuteHttpRequest<Playlists.GetByUser, Data.PlaylistList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.playlists.getByUser
    /// </summary>
    public Data.PlaylistList GetByUser(int? page, int? perPage)
    {
      return this.GetByUser(null, page, perPage);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.playlists.getByUser
    /// </summary>
    public Data.PlaylistList GetByUser()
    {
      return this.GetByUser(null, null, null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.playlists.list
    /// </summary>
    public Data.PlaylistList List(int? page, int? perPage)
    {
      StringDictionary parameters = new StringDictionary();
      if (page.HasValue) parameters.Add("page", page.Value.ToString(CultureInfo.InvariantCulture));
      if (perPage.HasValue) parameters.Add("per_page", perPage.Value.ToString(CultureInfo.InvariantCulture));

      return this.Service.ExecuteHttpRequest<Playlists.List, Data.PlaylistList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.playlists.list
    /// </summary>
    public Data.PlaylistList List()
    {
      return this.List(-1, -1);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.playlists.addVideo
    /// </summary>
    public Data.PlaylistVideoList AddVideo(string playlistId, string videoId)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("playlist_id", playlistId);
      parameters.Add("video_id", videoId);

      return this.Service.ExecuteHttpRequest<Playlists.AddVideo, Data.PlaylistVideoList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.playlists.removeVideo
    /// </summary>
    public Data.PlaylistVideoList RemoveVideo(string playlistId, int position)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("playlist_id", playlistId);
      parameters.Add("position", position.ToString(CultureInfo.InvariantCulture));

      return this.Service.ExecuteHttpRequest<Playlists.RemoveVideo, Data.PlaylistVideoList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.playlists.moveVideo
    /// </summary>
    public Data.PlaylistVideoList MoveVideo(string playlistId, int from, int to)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("playlist_id", playlistId);
      parameters.Add("from", from.ToString(CultureInfo.InvariantCulture));
      parameters.Add("to", to.ToString(CultureInfo.InvariantCulture));

      return this.Service.ExecuteHttpRequest<Playlists.MoveVideo, Data.PlaylistVideoList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.playlists.delete
    /// </summary>
    public Data.PlaylistList Delete(string playlistId)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("playlist_id", playlistId);

      return this.Service.ExecuteHttpRequest<Playlists.Delete, Data.PlaylistList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.playlists.create
    /// </summary>
    public Data.PlaylistVideoList Create(string name, Data.PlaylistType type, Data.PlaylistVisibilityType visibility, string videoIds)
    {
      return this.Create(name, type, visibility, videoIds, null, null, null, null, null, null, null, null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.playlists.create
    /// </summary>
    public Data.PlaylistVideoList Create(string name, Data.PlaylistType type, Data.PlaylistVisibilityType visibility)
    {
      return this.Create(name, type, visibility, null, null, null, null, null, null, null, null, null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.playlists.create
    /// </summary>
    public Data.PlaylistVideoList Create(
      string name, Data.PlaylistType? type, Data.PlaylistVisibilityType? visibility, string videoIds,
      string users, int? maxAge, string tags, int? min_views, int? max_views, DateTime? min_upload_date,
      DateTime? max_upload_date, Data.VideoListSortType? sort)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("name", name);
      if (type.HasValue) parameters.Add("type", ViddlerHelper.GetEnumName(type.Value.GetType().GetField(type.Value.ToString())));
      if (visibility.HasValue) parameters.Add("visibility", ViddlerHelper.GetEnumName(visibility.Value.GetType().GetField(visibility.Value.ToString())));
      if (!string.IsNullOrEmpty(videoIds)) parameters.Add("video_ids", videoIds);
      if (!string.IsNullOrEmpty(users)) parameters.Add("users", users);
      if (maxAge.HasValue) parameters.Add("max_age", maxAge.Value.ToString(CultureInfo.InvariantCulture));
      if (!string.IsNullOrEmpty(tags)) parameters.Add("tags", tags);
      if (min_views.HasValue) parameters.Add("min_views", min_views.Value.ToString(CultureInfo.InvariantCulture));
      if (max_views.HasValue) parameters.Add("max_views", max_views.Value.ToString(CultureInfo.InvariantCulture));
      if (min_upload_date.HasValue) parameters.Add("min_upload_date", min_upload_date.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
      if (max_upload_date.HasValue) parameters.Add("max_upload_date", max_upload_date.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
      if (sort.HasValue) parameters.Add("sort", ViddlerHelper.GetEnumName(sort.Value.GetType().GetField(sort.Value.ToString())));

      return this.Service.ExecuteHttpRequest<Playlists.Create, Data.PlaylistVideoList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.playlists.setDetails
    /// </summary>
    public Data.PlaylistVideoList SetDetails(
      string playlistId, string name, Data.PlaylistVisibilityType? visibility, string videoIds,
      string users, int? maxAge, string tags, int? min_views, int? max_views, DateTime? min_upload_date,
      DateTime? max_upload_date, Data.VideoListSortType? sort)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("playlist_id", playlistId);
      if (!string.IsNullOrEmpty(name)) parameters.Add("name", name);
      if (visibility.HasValue) parameters.Add("visibility", ViddlerHelper.GetEnumName(visibility.Value.GetType().GetField(visibility.Value.ToString())));
      if (videoIds != null) parameters.Add("video_ids", videoIds);
      if (users != null) parameters.Add("users", users);
      if (maxAge.HasValue) parameters.Add("max_age", maxAge.Value.ToString(CultureInfo.InvariantCulture));
      if (tags != null) parameters.Add("tags", tags);
      if (min_views.HasValue) parameters.Add("min_views", min_views.Value.ToString(CultureInfo.InvariantCulture));
      if (max_views.HasValue) parameters.Add("max_views", max_views.Value.ToString(CultureInfo.InvariantCulture));
      if (min_upload_date.HasValue) parameters.Add("min_upload_date", min_upload_date.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
      if (max_upload_date.HasValue) parameters.Add("max_upload_date", max_upload_date.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
      if (sort.HasValue) parameters.Add("sort", ViddlerHelper.GetEnumName(sort.Value.GetType().GetField(sort.Value.ToString())));

      return this.Service.ExecuteHttpRequest<Playlists.SetDetails, Data.PlaylistVideoList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.playlists.setDetails
    /// </summary>
    public Data.PlaylistVideoList SetDetails(string playlistId, string name, Data.PlaylistVisibilityType? visibility, string videoIds)
    {
      return this.SetDetails(playlistId, name, visibility, videoIds, null, null, null, null, null, null, null, null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.playlists.setDetails
    /// </summary>
    public Data.PlaylistVideoList SetDetails(string playlistId, string name, Data.PlaylistVisibilityType visibility)
    {
      return this.SetDetails(playlistId, name, visibility, null, null, null, null, null, null, null, null, null);
    }
  }
}