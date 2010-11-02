using System;
using System.Xml.Serialization;

namespace Viddler.Users
{
  /// <summary>
  /// Provides request parameters for Viddler API remote method: viddler.users.acceptFriendRequest
  /// </summary>
  /// <remarks>
  /// This class is not intended to be used in your code in any way.
  /// </remarks>
  [ViddlerMethod(MethodName = "viddler.users.acceptFriendRequest", ElementName = "list_result", IsSecure = false, IsSessionRequired = true, RequestType = ViddlerRequestType.Post)]
  public class AcceptFriendRequest : Viddler.Data.FriendRequestList
  {
  }
}
