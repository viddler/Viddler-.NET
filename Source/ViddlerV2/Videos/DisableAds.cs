using System;
using System.Xml.Serialization;

namespace Viddler.Videos
{
  /// <summary>
  /// Provides request parameters for Viddler API remote method: viddler.videos.disableAds
  /// </summary>
  /// <remarks>
  /// This class is not intended to be used in your code in any way.
  /// </remarks>
  [ViddlerMethod(MethodName = "viddler.videos.disableAds", ElementName = "result", IsSecure = false, IsSessionRequired = true, RequestType = ViddlerRequestType.Post)]
  public class DisableAds : Viddler.Data.AdsResult
  {
  }
}
