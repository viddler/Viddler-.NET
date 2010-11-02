using System;
using System.Xml.Serialization;

namespace Viddler.Groups
{
  /// <summary>
  /// Provides request parameters for Viddler API remote method: viddler.groups.getByVideo
  /// </summary>
  /// <remarks>
  /// This class is not intended to be used in your code in any way.
  /// </remarks>
  [ViddlerMethod(MethodName = "viddler.groups.getByVideo", ElementName = "list_result", IsSecure = false, IsSessionRequired = false, RequestType = ViddlerRequestType.Get)]
  public class GetByVideo : Viddler.Data.GroupList
  {
  }
}
