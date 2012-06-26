using System;
using System.Xml.Serialization;

namespace Viddler.Videos
{
  /// <summary>
  /// Provides request parameters for Viddler API remote method: viddler.videos.setClosedCaptioning
  /// </summary>
  /// <remarks>
  /// This class is not intended to be used in your code in any way.
  /// </remarks>
  [ViddlerMethod(MethodName = "viddler.videos.setClosedCaptioning", ElementName = "video", IsSecure = false, IsSessionRequired = true, RequestType = ViddlerRequestType.Post)]
  public class SetClosedCaptioning : Viddler.Data.Video
  {
  }
}
