using System;
using System.Xml.Serialization;

namespace Viddler.Playlists
{
  /// <summary>
  /// Provides request parameters for Viddler API remote method: viddler.playlists.moveVideo
  /// </summary>
  /// <remarks>
  /// This class is not intended to be used in your code in any way.
  /// </remarks>
  [ViddlerMethod(MethodName = "viddler.playlists.moveVideo", ElementName = "list_result", IsSecure = false, IsSessionRequired = true, RequestType = ViddlerRequestType.Post)]
  public class MoveVideo : Viddler.Data.PlaylistVideoList
  {
  }
}
