using System;
using System.Xml.Serialization;

namespace Viddler.Videos
{
  /// <summary>
  /// Provides request parameters for Viddler API remote method: viddler.videos.delete
  /// </summary>
  /// <remarks>
  /// This class is not intended to be used in your code in any way.
  /// </remarks>
  [ViddlerMethod(MethodName = "viddler.videos.delete", ElementName = "success", IsSecure = false, IsSessionRequired = true, RequestType = ViddlerRequestType.Post)]
  public class Delete : Viddler.ViddlerResponseSuccess
  {
  }
}
