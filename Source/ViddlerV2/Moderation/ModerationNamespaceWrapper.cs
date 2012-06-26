using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using Data = Viddler.Data;

namespace Viddler.Moderation
{
  /// <summary>
  /// Provides access to Viddler API methods located in viddler.moderation namespace.
  /// </summary>
  /// <remarks>Visit <a href="http://developers.viddler.com/" target="_blank">http://developers.viddler.com/</a> to get the full overview of methods contained in this class.</remarks>
  public sealed class ModerationNamespaceWrapper : ViddlerNamespaceProvider
  {
    /// <summary>
    /// Initializes a new instance of ResellersNamespaceWrapper class.
    /// </summary>
    internal ModerationNamespaceWrapper(ViddlerService service) : base(service)
    {
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.moderation.getComments
    /// </summary>
    public Data.CommentsModerationList GetComments()
    {
      return this.GetComments(null, null, null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.moderation.getComments
    /// </summary>
    public Data.CommentsModerationList GetComments(int? page, int? perPage, Data.CommentListSortType? sort)
    {
      StringDictionary parameters = new StringDictionary();
      if (page.HasValue) parameters.Add("page", page.Value.ToString(CultureInfo.InvariantCulture));
      if (perPage.HasValue) parameters.Add("per_page", perPage.Value.ToString(CultureInfo.InvariantCulture));
      if (sort.HasValue) parameters.Add("sort", ViddlerHelper.GetEnumName(sort.Value.GetType().GetField(sort.Value.ToString())));

      return this.Service.ExecuteHttpRequest<Moderation.GetComments, Data.CommentsModerationList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.moderation.setCommentStatus
    /// </summary>
    public Data.Comment SetCommentStatus(string commentId, Data.CommentsModerationStatus status)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("comment_id", commentId);
      parameters.Add("status", ViddlerHelper.GetEnumName(status.GetType().GetField(status.ToString())));

      return this.Service.ExecuteHttpRequest<Moderation.SetCommentStatus, Data.Comment>(parameters);
    }
  }
}