using System;
using System.Xml.Serialization;

namespace Viddler.Moderation
{
  /// <summary>
  /// Provides request parameters for Viddler API remote method: viddler.moderation.getComments
  /// </summary>
  /// <remarks>
  /// This class is not intended to be used in your code in any way.
  /// </remarks>
  [ViddlerMethod(MethodName = "viddler.moderation.getComments", ElementName = "list_result", IsSecure = false, IsSessionRequired = true, RequestType = ViddlerRequestType.Get)]
  public class GetComments : Viddler.Data.CommentsModerationList
  {
  }
}
