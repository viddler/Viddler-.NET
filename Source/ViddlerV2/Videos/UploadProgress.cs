using System;
using System.Xml.Serialization;

namespace Viddler.Videos
{
  /// <summary>
  /// Provides request parameters for Viddler API remote method: viddler.videos.uploadProgress
  /// </summary>
  /// <remarks>
  /// This class is not intended to be used in your code in any way.
  /// </remarks>
  [ViddlerMethod(MethodName = "viddler.videos.uploadProgress", ElementName = "upload_progress", IsSecure = false, IsSessionRequired = true, RequestType = ViddlerRequestType.Get)]
  public class UploadProgress : Viddler.Data.UploadProgress
  {
  }
}
