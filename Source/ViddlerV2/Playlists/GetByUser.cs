using System;
using System.Xml.Serialization;

namespace Viddler.Playlists
{
  /// <summary>
  /// Provides request parameters for Viddler API remote method: viddler.playlists.getByUser
  /// </summary>
  /// <remarks>
  /// This class is not intended to be used in your code in any way.
  /// </remarks>
  [ViddlerMethod(MethodName = "viddler.playlists.getByUser", ElementName = "list_result", IsSecure = false, IsSessionRequired = false, RequestType = ViddlerRequestType.Get)]
  public class GetByUser : Viddler.Data.PlaylistList
  {
  }
}