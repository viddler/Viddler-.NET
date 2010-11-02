using System;
using System.Xml.Serialization;

namespace Viddler.Users
{
  /// <summary>
  /// Provides request parameters for Viddler API remote method: viddler.users.auth
  /// </summary>
  /// <remarks>
  /// This class is not intended to be used in your code in any way.
  /// </remarks>
  [ViddlerMethod(MethodName = "viddler.users.auth", ElementName = "auth", IsSecure = true, IsSessionRequired = false, RequestType = ViddlerRequestType.Get)]
  public class Auth : Viddler.Data.UserSession
  {
  }
}
