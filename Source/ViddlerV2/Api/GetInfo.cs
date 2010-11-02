using System;
using System.Xml.Serialization;

namespace Viddler.Api
{
  /// <summary>
  /// Provides request parameters for Viddler API remote method: viddler.api.getInfo
  /// </summary>
  /// <remarks>
  /// This class is not intended to be used in your code in any way.
  /// </remarks>
  [ViddlerMethod(MethodName = "viddler.api.getInfo", ElementName = "viddler_api", IsSecure = false, IsSessionRequired = false, RequestType = ViddlerRequestType.Get)]
  public class GetInfo : Viddler.Data.ApiInfo
  {
  }
}
