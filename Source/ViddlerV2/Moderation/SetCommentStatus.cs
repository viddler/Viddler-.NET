using System;
using System.Xml.Serialization;

namespace Viddler.Moderation
{
  /// <summary>
  /// Provides request parameters for Viddler API remote method: viddler.moderation.setCommentStatus
  /// </summary>
  /// <remarks>
  /// This class is not intended to be used in your code in any way.
  /// </remarks>
  [ViddlerMethod(MethodName = "viddler.moderation.setCommentStatus", ElementName = "comment", IsSecure = false, IsSessionRequired = true, RequestType = ViddlerRequestType.Post)]
  public class SetCommentStatus : Viddler.Data.Comment
  {
  }
}
