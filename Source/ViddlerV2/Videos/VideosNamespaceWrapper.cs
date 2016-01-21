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
    /// <summary/>
    private Comments.CommentsNamespaceWrapper comments;

    /// <summary>
    /// Initializes a new instance of VideosNamespaceWrapper class.
    /// </summary>
    internal VideosNamespaceWrapper(ViddlerService service) : base(service)
    {
    }

    /// <summary>
    /// Provides access to Viddler API methods located in viddler.videos.comments namespace.
    /// </summary>
    public Comments.CommentsNamespaceWrapper Comments
    {
      get
      {
        if (this.comments == null)
        {
          this.comments = new Comments.CommentsNamespaceWrapper(this.Service);
        }
        return this.comments;
      }
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.addClosedCaptioning
    /// </summary>
    public Data.Video AddClosedCaptioning(string videoId, string language, string closedCaptioningUrl, bool? isDefault)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("video_id", videoId);
      parameters.Add("language", language);
      parameters.Add("closed_captioning_url", closedCaptioningUrl);
      if (isDefault.HasValue) parameters.Add("default", isDefault.Value ? "1" : "0");

      return this.Service.ExecuteHttpRequest<Videos.AddClosedCaptioning, Data.Video>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.setClosedCaptioning
    /// </summary>
    public Data.Video SetClosedCaptioning(string closedCaptioningId, string language, bool? enabled, bool? isDefault)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("closed_captioning_id", closedCaptioningId);
      if (!string.IsNullOrEmpty(language)) parameters.Add("language", language);
      if (isDefault.HasValue) parameters.Add("default", isDefault.Value ? "1" : "0");
      if (enabled.HasValue) parameters.Add("enabled", enabled.Value ? "1" : "0");

      return this.Service.ExecuteHttpRequest<Videos.SetClosedCaptioning, Data.Video>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.delClosedCaptioning
    /// </summary>
    public Data.Video DelClosedCaptioning(string closedCaptioningId)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("closed_captioning_id", closedCaptioningId);

      return this.Service.ExecuteHttpRequest<Videos.SetClosedCaptioning, Data.Video>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.upload
    /// </summary>
    public Data.Video Upload(string title, string tags, string description, bool? makePublic, string fileName, Stream fileStream, string videoid = null)
    {
      Data.UploadEndPoint endPoint = this.PrepareUpload(videoid);
      return this.Upload(title, tags, description, makePublic, fileName, fileStream, endPoint, videoid);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.upload
    /// </summary>
    /// <param name="title"></param>
    /// <param name="tags"></param>
    /// <param name="description"></param>
    /// <param name="makePublic"></param>
    /// <param name="fileName"></param>
    /// <param name="fileStream"></param>
    /// <param name="endPoint">endPoint information to upload video to.  If this is blank, and new endpoint will be created for you</param>
    /// <param name="videoid">Optional: VideoID to replace if you are trying to replace.</param>
    /// <returns></returns>
    public Data.Video Upload(string title, string tags, string description, bool? makePublic, string fileName, Stream fileStream, Data.UploadEndPoint endPoint, string videoid = null)
    {
      if (endPoint == null) endPoint = this.PrepareUpload(videoid);

      StringDictionary parameters = new StringDictionary();
      if (!string.IsNullOrEmpty(videoid)) parameters.Add("video_id", videoid);
      else
      {
         parameters.Add("title", title);
         if (tags != null) parameters.Add("tags", tags);
         if (description != null) parameters.Add("description", description);
         if (makePublic.HasValue) parameters.Add("make_public", makePublic.Value ? "1" : "0");
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
    public Data.Video Upload(string title, string tags, string description, bool? makePublic, string localPath, string videoid = null)
    {
      Data.UploadEndPoint endPoint = this.PrepareUpload(videoid);
      return this.Upload(title, tags, description, makePublic, localPath, endPoint, videoid);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.upload
    /// </summary>
    public Data.Video Upload(string title, string tags, string description, bool? makePublic, string localPath, Data.UploadEndPoint endPoint, string videoid = null)
    {
      Data.Video responseObject;
      FileInfo file = new FileInfo(localPath);
      if (file.Exists)
      {
        using (FileStream stream = file.OpenRead())
        {
          responseObject = this.Upload(title, tags, description, makePublic, file.Name, stream, endPoint, videoid);
        }
      }
      else
      {
        responseObject = this.Upload(title, tags, description, makePublic, null, Stream.Null, endPoint, videoid);
      }
      return responseObject;
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.prepareUpload
    /// </summary>
    public Data.UploadEndPoint PrepareUpload(string video_id = null)
    {
            StringDictionary parameters = new StringDictionary();
            if (!string.IsNullOrEmpty(video_id))
            {
                parameters.Add("allow_replace", "1");
            }

            return this.Service.ExecuteHttpRequest<Videos.PrepareUpload, Data.UploadEndPoint>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.uploadProgress
    /// </summary>
    public Data.UploadProgress UploadProgress(string token)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("token", token);

      return this.Service.ExecuteHttpRequest<Videos.UploadProgress, Data.UploadProgress>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.search
    /// </summary>
    public Data.VideoList SearchYourVideos(string query, DateTime? minUploadDate, DateTime? maxUploadDate, int? maxAge, int? page, int? perPage, Data.VideoListSortType? sort)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("type", "yourvideos");
      parameters.Add("query", query);
      if (minUploadDate.HasValue) parameters.Add("min_upload_date", minUploadDate.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
      if (maxUploadDate.HasValue) parameters.Add("max_upload_date", maxUploadDate.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
      if (maxAge.HasValue) parameters.Add("max_age", maxAge.Value.ToString(CultureInfo.InvariantCulture));
      if (sort.HasValue) parameters.Add("sort", ViddlerHelper.GetEnumName(sort.Value.GetType().GetField(sort.Value.ToString())));
      if (page.HasValue) parameters.Add("page", page.Value.ToString(CultureInfo.InvariantCulture));
      if (perPage.HasValue) parameters.Add("per_page", perPage.Value.ToString(CultureInfo.InvariantCulture));
      if (this.Service.IsAuthenticated) parameters.Add("sessionid", this.Service.SessionId);

      return this.Service.ExecuteHttpRequest<Videos.Search, Data.VideoList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.search
    /// </summary>
    public Data.VideoList SearchUser(string user, int? page, int? perPage, Data.VideoListSortType? sort)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("type", "user");
      parameters.Add("user", user);
      if (sort.HasValue) parameters.Add("sort", ViddlerHelper.GetEnumName(sort.Value.GetType().GetField(sort.Value.ToString())));
      if (page.HasValue) parameters.Add("page", page.Value.ToString(CultureInfo.InvariantCulture));
      if (perPage.HasValue) parameters.Add("per_page", perPage.Value.ToString(CultureInfo.InvariantCulture));
      if (this.Service.IsAuthenticated) parameters.Add("sessionid", this.Service.SessionId);

      return this.Service.ExecuteHttpRequest<Videos.Search, Data.VideoList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.search
    /// </summary>
    public Data.VideoList SearchAllVideos(string query, int? page, int? perPage, Data.VideoListSortType? sort)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("type", "allvideos");
      parameters.Add("query", query);
      if (sort.HasValue) parameters.Add("sort", ViddlerHelper.GetEnumName(sort.Value.GetType().GetField(sort.Value.ToString())));
      if (page.HasValue) parameters.Add("page", page.Value.ToString(CultureInfo.InvariantCulture));
      if (perPage.HasValue) parameters.Add("per_page", perPage.Value.ToString(CultureInfo.InvariantCulture));
      if (this.Service.IsAuthenticated) parameters.Add("sessionid", this.Service.SessionId);

      return this.Service.ExecuteHttpRequest<Videos.Search, Data.VideoList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getByUser
    /// </summary>
    public Data.VideoList GetByUser(string userName, string tags, bool? status, Data.PermissionLevel? visibility, int? page, int? perPage, Data.VideoListSortType? sort, bool? idOnly)
    {
      StringDictionary parameters = new StringDictionary();
      if (!string.IsNullOrEmpty(userName)) parameters.Add("user", userName);
      if (sort.HasValue) parameters.Add("sort", ViddlerHelper.GetEnumName(sort.Value.GetType().GetField(sort.Value.ToString())));
      if (visibility.HasValue) parameters.Add("visibility", ViddlerHelper.GetEnumName(visibility.Value.GetType().GetField(visibility.Value.ToString())));
      if (page.HasValue) parameters.Add("page", page.Value.ToString(CultureInfo.InvariantCulture));
      if (perPage.HasValue) parameters.Add("per_page", perPage.Value.ToString(CultureInfo.InvariantCulture));
      if (status.HasValue) parameters.Add("status", status.Value ? "1" : "0");
      if (idOnly.HasValue) parameters.Add("id_only", idOnly.Value ? "1" : "0");
      if (!string.IsNullOrEmpty(tags)) parameters.Add("tags", tags);
      if (this.Service.IsAuthenticated) parameters.Add("sessionid", this.Service.SessionId);

      return this.Service.ExecuteHttpRequest<Videos.GetByUser, Data.VideoList>(parameters);
    }
    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getByUser
    /// </summary>
    public Data.VideoList GetByUser(string userName)
    {
      return this.GetByUser(userName, null, null, null, null, null, null, null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getByUser
    /// </summary>
    public Data.VideoList GetByUser(bool? status, Data.PermissionLevel? visibility, int? page, int? perPage, Data.VideoListSortType? sort, bool? idOnly)
    {
      return this.GetByUser(null, null, status, visibility, page, perPage, sort, idOnly);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getByUser
    /// </summary>
    public Data.VideoList GetByUser()
    {
      return this.GetByUser(null, null, null, null, null, null, null, null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getByTag
    /// </summary>
    public Data.VideoList GetByTag(string tag, bool? status, int? page, int? perPage, Data.VideoListSortType? sort, bool? idOnly)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("tag", tag);
      if (sort.HasValue) parameters.Add("sort", ViddlerHelper.GetEnumName(sort.Value.GetType().GetField(sort.Value.ToString())));
      if (page.HasValue) parameters.Add("page", page.Value.ToString(CultureInfo.InvariantCulture));
      if (perPage.HasValue) parameters.Add("per_page", perPage.Value.ToString(CultureInfo.InvariantCulture));
      if (status.HasValue) parameters.Add("status", status.Value ? "1" : "0");
      if (idOnly.HasValue) parameters.Add("id_only", idOnly.Value ? "1" : "0");
      if (this.Service.IsAuthenticated) parameters.Add("sessionid", this.Service.SessionId);

      return this.Service.ExecuteHttpRequest<Videos.GetByTag, Data.VideoList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getByTag
    /// </summary>
    public Data.VideoList GetByTag(string tag)
    {
      return this.GetByTag(tag, null, null, null, null, null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getDetails
    /// </summary>
    public Data.Video GetDetailsById(string videoId, bool? addComments, bool? addEmbedCode, bool? addProfile, bool? addViewToken, bool? includeMetadata, bool? status, bool? idOnly)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("video_id", videoId);
      if (addComments.HasValue) parameters.Add("add_comments", addComments.Value ? "1" : "0");
      if (addEmbedCode.HasValue) parameters.Add("add_embed_code", addEmbedCode.Value ? "1" : "0");
      if (status.HasValue) parameters.Add("status", status.Value ? "1" : "0");
      if (idOnly.HasValue) parameters.Add("id_only", idOnly.Value ? "1" : "0");
      if (addProfile.HasValue) parameters.Add("add_profile", addProfile.Value ? "1" : "0");
      if (addViewToken.HasValue) parameters.Add("add_view_token", addViewToken.Value ? "1" : "0");
      if (includeMetadata.HasValue) parameters.Add("include_metadata", includeMetadata.Value ? "1" : "0");
      if (this.Service.IsAuthenticated) parameters.Add("sessionid", this.Service.SessionId);

      return this.Service.ExecuteHttpRequest<Videos.GetDetails, Data.Video>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getDetails
    /// </summary>
    public Data.Video GetDetailsById(string videoId)
    {
      return this.GetDetailsById(videoId, null, null, null, null, null, null, null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getDetails
    /// </summary>
    public Data.Video GetDetailsByUrl(string url, bool? addComments, bool? addEmbedCode, bool? addProfile, bool? addViewToken, bool? includeMetadata, bool? status, bool? idOnly)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("url", url);
      if (addComments.HasValue) parameters.Add("add_comments", addComments.Value ? "1" : "0");
      if (addEmbedCode.HasValue) parameters.Add("add_embed_code", addEmbedCode.Value ? "1" : "0");
      if (status.HasValue) parameters.Add("status", status.Value ? "1" : "0");
      if (idOnly.HasValue) parameters.Add("id_only", idOnly.Value ? "1" : "0");
      if (addProfile.HasValue) parameters.Add("add_profile", addProfile.Value ? "1" : "0");
      if (addViewToken.HasValue) parameters.Add("add_view_token", addViewToken.Value ? "1" : "0");
      if (includeMetadata.HasValue) parameters.Add("include_metadata", includeMetadata.Value ? "1" : "0");
      if (this.Service.IsAuthenticated) parameters.Add("sessionid", this.Service.SessionId);

      return this.Service.ExecuteHttpRequest<Videos.GetDetails, Data.Video>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getDetails
    /// </summary>
    public Data.Video GetDetailsByUrl(string url)
    {
      return this.GetDetailsByUrl(url, null, null, null, null, null, null, null);
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
      return this.GetEmbedCode(videoId, null, null, null, null, null, null, null, null, null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getEmbedCode
    /// </summary>
    public Data.VideoEmbedCode GetEmbedCode(string videoId, int? width, int? height, Data.PlayerType? playerType,
      Data.PlayerWindowMode? wmode, bool? autoplay, bool? branding, int? offset, int? embedCodeType, string flashvar)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("video_id", videoId);
      if (width.HasValue) parameters.Add("width", width.Value.ToString(CultureInfo.InvariantCulture));
      if (height.HasValue) parameters.Add("height", height.Value.ToString(CultureInfo.InvariantCulture));
      if (playerType.HasValue) parameters.Add("player_type", ViddlerHelper.GetEnumName(playerType.Value.GetType().GetField(playerType.Value.ToString())));
      if (wmode.HasValue) parameters.Add("wmode", ViddlerHelper.GetEnumName(wmode.Value.GetType().GetField(wmode.Value.ToString())));
      if (autoplay.HasValue) parameters.Add("autoplay", autoplay.Value ? "1" : "0");
      if (branding.HasValue) parameters.Add("branding", branding.Value ? "1" : "0");
      if (offset.HasValue) parameters.Add("offset", offset.Value.ToString(CultureInfo.InvariantCulture));
      if (embedCodeType.HasValue) parameters.Add("embed_code_type", embedCodeType.Value.ToString(CultureInfo.InvariantCulture));
      if (!string.IsNullOrEmpty(flashvar)) parameters.Add("flashvar", flashvar);
      if (this.Service.IsAuthenticated) parameters.Add("sessionid", this.Service.SessionId);

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
    /// Calls the remote Viddler API method: viddler.videos.getRecordToken
    /// </summary>
    public string GetRecordToken()
    {
      Data.RecordToken responseObject = this.Service.ExecuteHttpRequest<Videos.GetRecordToken, Data.RecordToken>(null);
      return (responseObject != null) ? responseObject.Value : null;
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.getAdsStatus
    /// </summary>
    public Data.AdsStatus GetAdsStatus(string videoId)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("video_id", videoId);

      return this.Service.ExecuteHttpRequest<Videos.GetAdsStatus, Data.AdsStatus>(parameters);
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
    /// Calls the remote Viddler API method: viddler.videos.setDetails
    /// </summary>
    public Data.Video SetDetails(
      string videoId, string title, string description, int? ageLimit, string tags, bool? viewResetSecret, int? thumbnailIndex,
      Data.PermissionLevel? viewPermission, Data.PermissionLevel? embedPermission,
      Data.PermissionLevel? commentingPermission, Data.PermissionLevel? downloadPermission,
      Data.PermissionLevel? taggingPermission, Data.CommentsModerationLevel? commentsModerationLevel)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("video_id", videoId);
      if (!string.IsNullOrEmpty(title)) parameters.Add("title", title);
      if (description != null) parameters.Add("description", description);
      if (ageLimit.HasValue) parameters.Add("age_limit", ageLimit.Value.ToString(CultureInfo.InvariantCulture));
      if (thumbnailIndex.HasValue) parameters.Add("thumbnail_index", thumbnailIndex.Value.ToString(CultureInfo.InvariantCulture));
      if (viewResetSecret.HasValue) parameters.Add("view_reset_secret", viewResetSecret.Value ? "1" : "0");
      if (tags != null) parameters.Add("tags", tags);
      if (viewPermission.HasValue) parameters.Add("view_perm", ViddlerHelper.GetEnumName(viewPermission.Value.GetType().GetField(viewPermission.Value.ToString())));
      if (embedPermission.HasValue) parameters.Add("embed_perm", ViddlerHelper.GetEnumName(embedPermission.Value.GetType().GetField(embedPermission.Value.ToString())));
      if (commentingPermission.HasValue) parameters.Add("commenting_perm", ViddlerHelper.GetEnumName(commentingPermission.Value.GetType().GetField(commentingPermission.Value.ToString())));
      if (downloadPermission.HasValue) parameters.Add("download_perm", ViddlerHelper.GetEnumName(downloadPermission.Value.GetType().GetField(downloadPermission.Value.ToString())));
      if (taggingPermission.HasValue) parameters.Add("tagging_perm", ViddlerHelper.GetEnumName(taggingPermission.Value.GetType().GetField(taggingPermission.Value.ToString())));
      if (commentsModerationLevel.HasValue) parameters.Add("comments_moderation_level", ViddlerHelper.GetEnumName(commentsModerationLevel.Value.GetType().GetField(commentsModerationLevel.Value.ToString())));

      return this.Service.ExecuteHttpRequest<Videos.SetDetails, Data.Video>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.setDetails
    /// </summary>
    public Data.Video SetDetails(string videoId, string videoFileId, bool? fileFlashEnabled, bool? fileIPhoneEnabled, bool? fileIPadEnabled)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("video_id", videoId);
      if (fileFlashEnabled.HasValue) parameters.Add(string.Concat("file_", videoFileId, "_flash"), fileFlashEnabled.Value ? "1" : "0");
      if (fileIPhoneEnabled.HasValue) parameters.Add(string.Concat("file_", videoFileId, "_iphone"), fileIPhoneEnabled.Value ? "1" : "0");
      if (fileIPadEnabled.HasValue) parameters.Add(string.Concat("file_", videoFileId, "_ipad"), fileIPadEnabled.Value ? "1" : "0");

      return this.Service.ExecuteHttpRequest<Videos.SetDetails, Data.Video>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.setDetails
    /// </summary>
    public bool SetDetailsForMany(
      string videoIds, bool? viewResetSecret, int? thumbnailIndex,
      Data.PermissionLevel? viewPermission, Data.PermissionLevel? embedPermission,
      Data.PermissionLevel? commentingPermission, Data.PermissionLevel? downloadPermission,
      Data.PermissionLevel? taggingPermission)
    {
      StringDictionary parameters = new StringDictionary();
      if (string.IsNullOrEmpty(videoIds) || videoIds.IndexOf(',') == -1)
      {
        parameters.Add("video_id", string.Concat(videoIds, ",", videoIds));
      }
      else
      {
        parameters.Add("video_id", videoIds);
      }
      if (thumbnailIndex.HasValue) parameters.Add("thumbnail_index", thumbnailIndex.Value.ToString(CultureInfo.InvariantCulture));
      if (viewResetSecret.HasValue) parameters.Add("view_reset_secret", viewResetSecret.Value ? "1" : "0");
      if (viewPermission.HasValue) parameters.Add("view_perm", ViddlerHelper.GetEnumName(viewPermission.Value.GetType().GetField(viewPermission.Value.ToString())));
      if (embedPermission.HasValue) parameters.Add("embed_perm", ViddlerHelper.GetEnumName(embedPermission.Value.GetType().GetField(embedPermission.Value.ToString())));
      if (commentingPermission.HasValue) parameters.Add("commenting_perm", ViddlerHelper.GetEnumName(commentingPermission.Value.GetType().GetField(commentingPermission.Value.ToString())));
      if (downloadPermission.HasValue) parameters.Add("download_perm", ViddlerHelper.GetEnumName(downloadPermission.Value.GetType().GetField(downloadPermission.Value.ToString())));
      if (taggingPermission.HasValue) parameters.Add("tagging_perm", ViddlerHelper.GetEnumName(taggingPermission.Value.GetType().GetField(taggingPermission.Value.ToString())));

      ViddlerResponseSuccess responseObject = this.Service.ExecuteHttpRequest<Videos.SetDetailsForMany, ViddlerResponseSuccess>(parameters);
      return (responseObject != null && responseObject.IsSuccess);
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
    public Data.AdsResult EnableAds(string videoIds)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("video_ids", videoIds);

      return this.Service.ExecuteHttpRequest<Videos.EnableAds, Data.AdsResult>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.disableAds
    /// </summary>
    public Data.AdsResult DisableAds(string videoIds)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("video_ids", videoIds);

      return this.Service.ExecuteHttpRequest<Videos.DisableAds, Data.AdsResult>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.setThumbnail
    /// </summary>
    public Data.Video SetThumbnail(string videoId, int timePoint)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("video_id", videoId);
      parameters.Add("timepoint", timePoint.ToString(CultureInfo.InvariantCulture));

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
