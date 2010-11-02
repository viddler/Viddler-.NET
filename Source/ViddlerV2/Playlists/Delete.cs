using System;
using System.Xml.Serialization;

namespace Viddler.Playlists
{
  /// <summary>
  /// Provides request parameters for Viddler API remote method: viddler.playlists.delete
  /// </summary>
  /// <remarks>
  /// This class is not intended to be used in your code in any way.
  /// </remarks>
  [ViddlerMethod(MethodName = "viddler.playlists.delete", ElementName = "list_result", IsSecure = false, IsSessionRequired = true, RequestType = ViddlerRequestType.Post)]
  public class Delete : Viddler.Data.PlaylistList
  {
  }
}
