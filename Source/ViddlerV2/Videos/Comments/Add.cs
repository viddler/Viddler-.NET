using System;
using System.Xml.Serialization;

namespace Viddler.Videos.Comments
{
  /// <summary>
  /// Provides request parameters for Viddler API remote method: viddler.videos.comments.add
  /// </summary>
  /// <remarks>
  /// This class is not intended to be used in your code in any way.
  /// </remarks>
  [ViddlerMethod(MethodName = "viddler.videos.comments.add", ElementName = "video", IsSecure = false, IsSessionRequired = true, RequestType = ViddlerRequestType.Post)]
  public class Add : Data.Video
  {
  }
}