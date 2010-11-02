using System;
using System.Xml.Serialization;

namespace Viddler.Groups
{
  /// <summary>
  /// Provides request parameters for Viddler API remote method: viddler.groups.getVideos
  /// </summary>
  /// <remarks>
  /// This class is not intended to be used in your code in any way.
  /// </remarks>
  [ViddlerMethod(MethodName = "viddler.groups.getVideos", ElementName = "list_result", IsSecure = false, IsSessionRequired = false, RequestType = ViddlerRequestType.Get)]
  public class GetVideos : Viddler.Data.GroupVideoList
  {
  }
}
