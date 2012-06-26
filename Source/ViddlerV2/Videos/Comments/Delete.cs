using System;
using System.Xml.Serialization;

namespace Viddler.Videos.Comments
{
  /// <summary>
  /// Provides request parameters for Viddler API remote method: viddler.videos.comments.delete
  /// </summary>
  /// <remarks>
  /// This class is not intended to be used in your code in any way.
  /// </remarks>
  [ViddlerMethod(MethodName = "viddler.videos.comments.delete", ElementName = "video", IsSecure = false, IsSessionRequired = true, RequestType = ViddlerRequestType.Post)]
  public class Delete : Data.Video
  {
  }
}