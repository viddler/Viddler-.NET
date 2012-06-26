using System;
using System.Xml.Serialization;

namespace Viddler.Encoding
{
  /// <summary>
  /// Provides request parameters for Viddler API remote method: viddler.encoding.getSettings
  /// </summary>
  /// <remarks>
  /// This class is not intended to be used in your code in any way.
  /// </remarks>
  [ViddlerMethod(MethodName = "viddler.encoding.getSettings", ElementName = "encoding_settings", IsSecure = false, IsSessionRequired = true, RequestType = ViddlerRequestType.Get)]
  public class GetSettings : Viddler.Data.EncodingSettings
  {
  }
}