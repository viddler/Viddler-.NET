using System;
using System.Xml.Serialization;

namespace Viddler.Playlists
{
  /// <summary>
  /// Provides request parameters for Viddler API remote method: viddler.playlists.list
  /// </summary>
  /// <remarks>
  /// This class is not intended to be used in your code in any way.
  /// </remarks>
  [ViddlerMethod(MethodName = "viddler.playlists.list", ElementName = "list_result", IsSecure = false, IsSessionRequired = true, RequestType = ViddlerRequestType.Get)]
  public class List : Viddler.Data.PlaylistList
  {
  }
}
