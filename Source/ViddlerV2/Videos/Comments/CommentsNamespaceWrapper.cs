using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using Data = Viddler.Data;

namespace Viddler.Videos.Comments
{
  /// <summary>
  /// Provides access to Viddler API methods located in viddler.videos.comments namespace.
  /// </summary>
  /// <remarks>Visit <a href="http://developers.viddler.com/" target="_blank">http://developers.viddler.com/</a> to get the full overview of methods contained in this class.</remarks>
  public sealed class CommentsNamespaceWrapper : ViddlerNamespaceProvider
  {
    /// <summary>
    /// Initializes a new instance of ApiNamespaceWrapper class.
    /// </summary>
    internal CommentsNamespaceWrapper(ViddlerService service) : base(service)
    {
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.comments.delete
    /// </summary>
    public Data.Video Delete(string commentId)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("comment_id", commentId);

      return this.Service.ExecuteHttpRequest<Videos.Comments.Delete, Data.Video>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.comments.add
    /// </summary>
    public Data.Video Add(string videoId, string text, int? timepoint)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("video_id", videoId);
      parameters.Add("text", text);
      if (timepoint.HasValue) parameters.Add("timepoint", timepoint.Value.ToString(CultureInfo.InvariantCulture));

      return this.Service.ExecuteHttpRequest<Videos.Comments.Add, Data.Video>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.comments.add
    /// </summary>
    public Data.Video Add(string videoId, string text)
    {
      return this.Add(videoId, text, null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.comments.get
    /// </summary>
    public Data.CommentList GetById(string videoId)
    {
      return this.GetById(videoId, null, null, null, null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.comments.get
    /// </summary>
    public Data.CommentList GetById(string videoId, string parentId, int? page, int? perPage, Data.CommentListSortType? sort)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("video_id", videoId);
      if (!string.IsNullOrEmpty(parentId)) parameters.Add("parent_id", parentId);
      if (sort.HasValue) parameters.Add("sort", ViddlerHelper.GetEnumName(sort.Value.GetType().GetField(sort.Value.ToString())));
      if (page.HasValue) parameters.Add("page", page.Value.ToString(CultureInfo.InvariantCulture));
      if (perPage.HasValue) parameters.Add("per_page", perPage.Value.ToString(CultureInfo.InvariantCulture));
      if (this.Service.IsAuthenticated) parameters.Add("sessionid", this.Service.SessionId);

      return this.Service.ExecuteHttpRequest<Videos.Comments.Get, Data.CommentList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.comments.get
    /// </summary>
    public Data.CommentList GetByUrl(string url)
    {
      return this.GetByUrl(url, null, null, null, null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.videos.comments.get
    /// </summary>
    public Data.CommentList GetByUrl(string url, string parentId, int? page, int? perPage, Data.CommentListSortType? sort)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("url", url);
      if (sort.HasValue) parameters.Add("sort", ViddlerHelper.GetEnumName(sort.Value.GetType().GetField(sort.Value.ToString())));
      if (page.HasValue) parameters.Add("page", page.Value.ToString(CultureInfo.InvariantCulture));
      if (perPage.HasValue) parameters.Add("per_page", perPage.Value.ToString(CultureInfo.InvariantCulture));
      if (this.Service.IsAuthenticated) parameters.Add("sessionid", this.Service.SessionId);

      return this.Service.ExecuteHttpRequest<Videos.Comments.Get, Data.CommentList>(parameters);
    }
  }
}