using System;
using System.Xml.Serialization;

namespace Viddler.Resellers
{
  /// <summary>
  /// Provides request parameters for Viddler API remote method: viddler.resellers.removeSubaccounts
  /// </summary>
  /// <remarks>
  /// This class is not intended to be used in your code in any way.
  /// </remarks>
  [ViddlerMethod(MethodName = "viddler.resellers.removeSubaccounts", ElementName = "list_result", IsSecure = false, IsSessionRequired = true, RequestType = ViddlerRequestType.Get)]
  public class RemoveSubaccounts : Viddler.Data.SubaccountList
  {
  }
}