﻿using System;
using System.Xml.Serialization;

namespace Viddler.Groups
{
  /// <summary>
  /// Provides request parameters for Viddler API remote method: viddler.groups.removeVideo
  /// </summary>
  /// <remarks>
  /// This class is not intended to be used in your code in any way.
  /// </remarks>
  [ViddlerMethod(MethodName = "viddler.groups.removeVideo", ElementName = "list_result", IsSecure = false, IsSessionRequired = true, RequestType = ViddlerRequestType.Post)]
  public class RemoveVideo : Viddler.Data.GroupVideoList
  {
  }
}
