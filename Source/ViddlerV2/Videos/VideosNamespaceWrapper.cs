using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using Data = Viddler.Data;

namespace Viddler.Videos
{
  /// <summary>
  /// Provides access to Viddler API methods located in viddler.videos namespace.
  /// </summary>
  /// <remarks>Visit <a href="http://developers.viddler.com/" target="_blank">http://developers.viddler.com/</a> to get the full overview of methods contained in this class.</remarks>
  public sealed class VideosNamespaceWrapper : ViddlerNamespaceProvider
  {
    /// <summary>
    /// Initializes a new instance of VideosNamespaceWrapper class.
    /// </summary>
    internal VideosNamespaceWrapper(ViddlerService service)
      : base(service)
    {
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.upload
    /// </summary>
    public Data.Video Upload(string title, string tags, string description, bool? makePublic, string fileName, Stream fileStream, bool useEndPoint)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("title", title);
      if (!string.IsNullOrEmpty(tags)) parameters.Add("tags", tags);
      if (!string.IsNullOrEmpty(description)) parameters.Add("description", description);
      if (makePublic.HasValue) parameters.Add("make_public", makePublic.Value ? "1" : "0");

      Data.UploadEndPoint endPoint = null;
      if (useEndPoint)
      {
        endPoint = this.PrepareUpload();
      }

      Data.Video video;
      if (fileStream != null && !fileStream.CanSeek)
      {
        using (MemoryStream seekableStream = new MemoryStream())
        {
          byte[] buffer = new byte[4096];
          int bytesRead = 0;
          while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
          {
            seekableStream.Write(buffer, 0, bytesRead);
          }
          seekableStream.Position = 0;

          video = this.Service.ExecuteHttpRequest<Videos.Upload, Data.Video>(parameters, fileName, seekableStream, endPoint);
        }
      }
      else
      {
        video = this.Service.ExecuteHttpRequest<Videos.Upload, Data.Video>(parameters, fileName, fileStream, endPoint);
      }
      return video;
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.upload
    /// </summary>
    public Data.Video Upload(string title, string tags, string description, bool? makePublic, string localPath, bool useEndPoint)
    {
      Data.Video responseObject;
      FileInfo file = new FileInfo(localPath);
      if (file.Exists)
      {
        using (FileStream stream = file.OpenRead())
        {
          responseObject = this.Upload(title, tags, description, makePublic, file.Name, stream, useEndPoint);
        }
      }
      else
      {
        responseObject = this.Upload(title, tags, description, makePublic, null, Stream.Null, useEndPoint);
      }
      return responseObject;
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.prepareUpload
    /// </summary>
    public Data.UploadEndPoint PrepareUpload()
    {
      return this.Service.ExecuteHttpRequest<Videos.PrepareUpload, Data.UploadEndPoint>(null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getByUser
    /// </summary>
    public Data.VideoList GetByUser(string userName, bool? status, int? page, int? perPage, Data.VideoListSortType? sort)
    {
      StringDictionary parameters = new StringDictionary();
      if (userName != null || !this.Service.IsAuthenticated) parameters.Add("user", userName);
      if (sort.HasValue) parameters.Add("sort", ViddlerHelper.GetEnumName(sort.Value.GetType().GetField(sort.Value.ToString())));
      if (page.HasValue) parameters.Add("page", page.Value.ToString(CultureInfo.InvariantCulture));
      if (perPage.HasValue) parameters.Add("per_page", perPage.Value.ToString(CultureInfo.InvariantCulture));
      if (status.HasValue) parameters.Add("status", status.Value ? "1" : "0");
      if (this.Service.IsAuthenticated) parameters.Add("sessionid", this.Service.SessionId);
    
      return this.Service.ExecuteHttpRequest<Videos.GetByUser, Data.VideoList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getByUser
    /// </summary>
    public Data.VideoList GetByUser(string userName)
    {
      return this.GetByUser(userName, null, null, null, null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getByUser
    /// </summary>
    public Data.VideoList GetByUser(bool? status, int? page, int? perPage, Data.VideoListSortType? sort)
    {
      return this.GetByUser(null, status, page, perPage, sort);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getByUser
    /// </summary>
    public Data.VideoList GetByUser()
    {
      return this.GetByUser(null, null, null, null, null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getByTag
    /// </summary>
    public Data.VideoList GetByTag(string tag, bool? status, int? page, int? perPage, Data.VideoListSortType? sort)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("tag", tag);
      if (sort.HasValue) parameters.Add("sort", ViddlerHelper.GetEnumName(sort.Value.GetType().GetField(sort.Value.ToString())));
      if (page.HasValue) parameters.Add("page", page.Value.ToString(CultureInfo.InvariantCulture));
      if (perPage.HasValue) parameters.Add("per_page", perPage.Value.ToString(CultureInfo.InvariantCulture));
      if (status.HasValue) parameters.Add("status", status.Value ? "1" : "0");
      if (this.Service.IsAuthenticated) parameters.Add("sessionid", this.Service.SessionId);

      return this.Service.ExecuteHttpRequest<Videos.GetByTag, Data.VideoList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getByTag
    /// </summary>
    public Data.VideoList GetByTag(string tag)
    {
      return this.GetByTag(tag, null, null, null, null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getDetails
    /// </summary>
    public Data.Video GetDetails(string videoId, bool? includeComments, bool? addEmbedCode, bool? status)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("video_id", videoId);
      if (includeComments.HasValue) parameters.Add("include_comments", includeComments.Value ? "1" : "0");
      if (addEmbedCode.HasValue) parameters.Add("add_embed_code", addEmbedCode.Value ? "1" : "0");
      if (status.HasValue) parameters.Add("status", status.Value ? "1" : "0");
      if (this.Service.IsAuthenticated) parameters.Add("sessionid", this.Service.SessionId);

      return this.Service.ExecuteHttpRequest<Videos.GetDetails, Data.Video>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getDetails
    /// </summary>
    public Data.Video GetDetailsById(string videoId)
    {
      return this.GetDetails(videoId, null, null, null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getDetails
    /// </summary>
    public Data.Video GetDetailsByUrl(string url, bool? includeComments, bool? addEmbedCode, bool? status)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("url", url);
      if (includeComments.HasValue) parameters.Add("include_comments", includeComments.Value ? "1" : "0");
      if (addEmbedCode.HasValue) parameters.Add("add_embed_code", addEmbedCode.Value ? "1" : "0");
      if (status.HasValue) parameters.Add("status", status.Value ? "1" : "0");
      if (this.Service.IsAuthenticated) parameters.Add("sessionid", this.Service.SessionId);

      return this.Service.ExecuteHttpRequest<Videos.GetDetails, Data.Video>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getDetails
    /// </summary>
    public Data.Video GetDetailsByUrl(string url)
    {
      return this.GetDetailsByUrl(url, null, null, null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getFavorites
    /// </summary>
    public Data.FavoriteList GetFavorites(string userName, int? page, int? perPage)
    {
      StringDictionary parameters = new StringDictionary();
      if (page.HasValue) parameters.Add("page", page.Value.ToString(CultureInfo.InvariantCulture));
      if (perPage.HasValue) parameters.Add("per_page", perPage.Value.ToString(CultureInfo.InvariantCulture));
      if (!string.IsNullOrEmpty(userName))
      {
        parameters.Add("user", userName);
      }
      if (string.IsNullOrEmpty(userName) && this.Service.IsAuthenticated)
      {
        parameters.Add("sessionid", this.Service.SessionId);
      }

      return this.Service.ExecuteHttpRequest<Videos.GetFavorites, Data.FavoriteList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getFavorites
    /// </summary>
    public Data.FavoriteList GetFavorites(string userName)
    {
      return this.GetFavorites(userName, null, null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getFavorites
    /// </summary>
    public Data.FavoriteList GetFavorites(int? page, int? perPage)
    {
      return this.GetFavorites(null, page, perPage);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getFavorites
    /// </summary>
    public Data.FavoriteList GetFavorites()
    {
      return this.GetFavorites(null, null, null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getEmbedCodeTypes
    /// </summary>
    public Data.VideoEmbedCodeTypeList GetEmbedCodeTypes()
    {
      return this.Service.ExecuteHttpRequest<Videos.GetEmbedCodeTypes, Data.VideoEmbedCodeTypeList>(null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getEmbedCode
    /// </summary>
    public Data.VideoEmbedCode GetEmbedCode(string videoId)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("video_id", videoId);

      return this.Service.ExecuteHttpRequest<Videos.GetEmbedCode, Data.VideoEmbedCode>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getFeatured
    /// </summary>
    public Data.FeaturedVideoList GetFeatured(int? page, int? perPage, Data.FeaturedVideoListSortType? sort)
    {
      StringDictionary parameters = new StringDictionary();
      if (page.HasValue) parameters.Add("page", page.Value.ToString(CultureInfo.InvariantCulture));
      if (perPage.HasValue) parameters.Add("per_page", perPage.Value.ToString(CultureInfo.InvariantCulture));
      if (sort.HasValue) parameters.Add("sort", ViddlerHelper.GetEnumName(sort.Value.GetType().GetField(sort.Value.ToString())));

      return this.Service.ExecuteHttpRequest<Videos.GetFeatured, Data.FeaturedVideoList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getFeatured
    /// </summary>
    public Data.FeaturedVideoList GetFeatured()
    {
      return this.GetFeatured(null, null, null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getPartner
    /// </summary>
    public Data.PartnerVideoList GetPartner(int? page, int? perPage)
    {
      StringDictionary parameters = new StringDictionary();
      if (page.HasValue) parameters.Add("page", page.Value.ToString(CultureInfo.InvariantCulture));
      if (perPage.HasValue) parameters.Add("per_page", perPage.Value.ToString(CultureInfo.InvariantCulture));

      return this.Service.ExecuteHttpRequest<Videos.GetPartner, Data.PartnerVideoList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getPartner
    /// </summary>
    public Data.PartnerVideoList GetPartner()
    {
      return this.GetPartner(null, null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getFriendsVideos
    /// </summary>
    public Data.FriendVideoList GetFriendsVideos(int? page, int? perPage)
    {
      StringDictionary parameters = new StringDictionary();
      if (page.HasValue) parameters.Add("page", page.Value.ToString(CultureInfo.InvariantCulture));
      if (perPage.HasValue) parameters.Add("per_page", perPage.Value.ToString(CultureInfo.InvariantCulture));

      return this.Service.ExecuteHttpRequest<Videos.GetFriendsVideos, Data.FriendVideoList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getFriendsVideos
    /// </summary>
    public Data.FriendVideoList GetFriendsVideos()
    {
      return this.GetFriendsVideos(null, null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getRecordToken
    /// </summary>
    public string GetRecordToken()
    {
      Data.RecordToken responseObject = this.Service.ExecuteHttpRequest<Videos.GetRecordToken, Data.RecordToken>(null);
      return (responseObject != null) ? responseObject.Value : null;
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getSubscribed
    /// </summary>
    public Data.SubscribedVideoList GetSubscribed(int? page, int? perPage)
    {
      StringDictionary parameters = new StringDictionary();
      if (page.HasValue) parameters.Add("page", page.Value.ToString(CultureInfo.InvariantCulture));
      if (perPage.HasValue) parameters.Add("per_page", perPage.Value.ToString(CultureInfo.InvariantCulture));

      return this.Service.ExecuteHttpRequest<Videos.GetSubscribed, Data.SubscribedVideoList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getSubscribed
    /// </summary>
    public Data.SubscribedVideoList GetSubscribed()
    {
      return this.GetSubscribed(null, null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getAdsStatus
    /// </summary>
    public Data.VideoAdsStatus GetAdsStatus(string videoId)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("video_id", videoId);

      return this.Service.ExecuteHttpRequest<Videos.GetAdsStatus, Data.VideoAdsStatus>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.setPermalink
    /// </summary>
    public Data.Video SetPermaLink(string videoId)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("video_id", videoId);

      return this.Service.ExecuteHttpRequest<Videos.SetPermaLink, Data.Video>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.favorite
    /// </summary>
    public bool Favorite(string videoId)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("video_id", videoId);

      ViddlerResponseSuccess responseObject = this.Service.ExecuteHttpRequest<Videos.Favorite, ViddlerResponseSuccess>(parameters);
      return (responseObject != null && responseObject.IsSuccess);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.unfavorite
    /// </summary>
    public bool Unfavorite(string videoId)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("video_id", videoId);

      ViddlerResponseSuccess responseObject = this.Service.ExecuteHttpRequest<Videos.Unfavorite, ViddlerResponseSuccess>(parameters);
      return (responseObject != null && responseObject.IsSuccess);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.setDetails
    /// </summary>
    public Data.Video SetDetails(
      string videoId, string title, string description, int? ageLimit, string tags,
      Data.VideoPermissionLevel? viewPermission, string viewUsers, string viewUseSecret,
      Data.VideoPermissionLevel? embedPermission, string embedUsers,
      Data.VideoPermissionLevel? commentingPermission, string commentingUsers,
      Data.VideoPermissionLevel? downloadPermission, string downloadUsers,
      Data.VideoPermissionLevel? taggingPermission, string taggingUsers)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("video_id", videoId);
      if (title != null) parameters.Add("title", title);
      if (description != null) parameters.Add("description", description);
      if (ageLimit.HasValue) parameters.Add("age_limit", ageLimit.Value.ToString(CultureInfo.InvariantCulture));
      if (tags != null) parameters.Add("tags", tags);
      if (viewPermission.HasValue)
      {
        parameters.Add("view_perm", ViddlerHelper.GetEnumName(viewPermission.Value.GetType().GetField(viewPermission.Value.ToString())));
        if (viewUsers != null) parameters.Add("view_users", viewUsers);
        if (viewUseSecret != null) parameters.Add("view_use_secret", viewUseSecret);
      }
      if (embedPermission.HasValue)
      {
        parameters.Add("embed_perm", ViddlerHelper.GetEnumName(embedPermission.Value.GetType().GetField(embedPermission.Value.ToString())));
        if (embedUsers != null) parameters.Add("embed_users", embedUsers);
      }
      if (commentingPermission.HasValue)
      {
        parameters.Add("commenting_perm", ViddlerHelper.GetEnumName(commentingPermission.Value.GetType().GetField(commentingPermission.Value.ToString())));
        if (commentingUsers != null) parameters.Add("commenting_users", commentingUsers);
      }
      if (downloadPermission.HasValue)
      {
        parameters.Add("download_perm", ViddlerHelper.GetEnumName(downloadPermission.Value.GetType().GetField(downloadPermission.Value.ToString())));
        if (downloadUsers != null) parameters.Add("download_users", downloadUsers);
      }
      if (taggingPermission.HasValue)
      {
        parameters.Add("tagging_perm", ViddlerHelper.GetEnumName(taggingPermission.Value.GetType().GetField(taggingPermission.Value.ToString())));
        if (taggingUsers != null) parameters.Add("tagging_users", taggingUsers);
      }

      return this.Service.ExecuteHttpRequest<Videos.SetDetails, Data.Video>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.setDetails
    /// </summary>
    public Data.Video SetDetails(string videoId, int? fileFlashProfile, bool? fileFlashEnabled, int? fileIPhoneProfile, bool? fileIPhoneEnabled, int? fileIPadProfile, bool? fileIPadEnabled)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("video_id", videoId);
      if (fileFlashProfile.HasValue && fileFlashEnabled.HasValue) parameters.Add(string.Concat("file_", fileFlashProfile.Value, "_flash"), fileFlashEnabled.Value ? "1" : "0");
      if (fileIPhoneProfile.HasValue && fileIPhoneEnabled.HasValue) parameters.Add(string.Concat("file_", fileIPhoneProfile.Value, "_iphone"), fileIPhoneEnabled.Value ? "1" : "0");
      if (fileIPadProfile.HasValue && fileIPadEnabled.HasValue) parameters.Add(string.Concat("file_", fileIPadProfile.Value, "_ipad"), fileIPadEnabled.Value ? "1" : "0");

      return this.Service.ExecuteHttpRequest<Videos.SetDetails, Data.Video>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.delete
    /// </summary>
    public bool Delete(string videoId)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("video_id", videoId);

      ViddlerResponseSuccess responseObject = this.Service.ExecuteHttpRequest<Videos.Delete, ViddlerResponseSuccess>(parameters);
      return (responseObject != null && responseObject.IsSuccess);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.delFile
    /// </summary>
    public Data.Video DelFile(string fileId)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("file_id", fileId);

      return this.Service.ExecuteHttpRequest<Videos.DelFile, Data.Video>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.enableAds
    /// </summary>
    public Data.VideoAdsResult EnableAds(string videoIds)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("video_ids", videoIds);

      return this.Service.ExecuteHttpRequest<Videos.EnableAds, Data.VideoAdsResult>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.disableAds
    /// </summary>
    public Data.VideoAdsResult DisableAds(string videoIds)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("video_ids", videoIds);

      return this.Service.ExecuteHttpRequest<Videos.DisableAds, Data.VideoAdsResult>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.setThumbnail
    /// </summary>
    public Data.Video SetThumbnail(string videoId, bool timePoint)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("video_id", videoId);
      parameters.Add("timepoint", timePoint ? "1" : "0");

      return this.Service.ExecuteHttpRequest<Videos.SetThumbnail, Data.Video>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.setThumbnail
    /// </summary>
    public Data.Video SetThumbnail(string videoId, Stream fileStream)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("video_id", videoId);

      Data.Video video;
      if (fileStream != null && !fileStream.CanSeek)
      {
        using (MemoryStream seekableStream = new MemoryStream())
        {
          byte[] buffer = new byte[4096];
          int bytesRead = 0;
          while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
          {
            seekableStream.Write(buffer, 0, bytesRead);
          }
          seekableStream.Position = 0;

          video = this.Service.ExecuteHttpRequest<Videos.SetThumbnailFile, Data.Video>(parameters, null, seekableStream, null);
        }
      }
      else
      {
        video = this.Service.ExecuteHttpRequest<Videos.SetThumbnailFile, Data.Video>(parameters, null, fileStream, null);
      }
      return video;
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.setThumbnail
    /// </summary>
    public Data.Video SetThumbnail(string videoId, string localPath)
    {
      Data.Video responseObject;
      if (File.Exists(localPath))
      {
        using (FileStream stream = File.OpenRead(localPath))
        {
          responseObject = this.SetThumbnail(videoId, stream);
        }
      }
      else
      {
        responseObject = this.SetThumbnail(videoId, Stream.Null);
      }
      return responseObject;
    }
  }
}
