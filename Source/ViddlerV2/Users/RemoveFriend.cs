using System;
using System.Xml.Serialization;

namespace Viddler.Users
{
  /// <summary>
  /// Provides request parameters for Viddler API remote method: viddler.users.removeFriend
  /// </summary>
  /// <remarks>
  /// This class is not intended to be used in your code in any way.
  /// </remarks>
  [ViddlerMethod(MethodName = "viddler.users.removeFriend", ElementName = "friends", IsSecure = false, IsSessionRequired = true, RequestType = ViddlerRequestType.Post)]
  public class RemoveFriend : Viddler.Data.Friends
  {
  }
}
