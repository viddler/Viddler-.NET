using System;
using System.Xml.Serialization;

namespace Viddler.Videos.Comments
{
  /// <summary>
  /// Provides request parameters for Viddler API remote method: viddler.videos.comments.get
  /// </summary>
  /// <remarks>
  /// This class is not intended to be used in your code in any way.
  /// </remarks>
  [ViddlerMethod(MethodName = "viddler.videos.comments.get", ElementName = "list_result", IsSecure = false, IsSessionRequired = false, RequestType = ViddlerRequestType.Get)]
  public class Get : Data.CommentList
  {
  }
}