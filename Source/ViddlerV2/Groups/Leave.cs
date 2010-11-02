using System;
using System.Xml.Serialization;

namespace Viddler.Groups
{
  /// <summary>
  /// Provides request parameters for Viddler API remote method: viddler.groups.leave
  /// </summary>
  /// <remarks>
  /// This class is not intended to be used in your code in any way.
  /// </remarks>
  [ViddlerMethod(MethodName = "viddler.groups.leave", ElementName = "list_result", IsSecure = false, IsSessionRequired = true, RequestType = ViddlerRequestType.Post)]
  public class Leave : Viddler.Data.GroupList
  {
  }
}
