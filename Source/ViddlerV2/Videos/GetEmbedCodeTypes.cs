﻿using System;
using System.Xml.Serialization;

namespace Viddler.Videos
{
  /// <summary>
  /// Provides request parameters for Viddler API remote method: viddler.videos.getEmbedCodeTypes
  /// </summary>
  /// <remarks>
  /// This class is not intended to be used in your code in any way.
  /// </remarks>
  [ViddlerMethod(MethodName = "viddler.videos.getEmbedCodeTypes", ElementName = "list_result", IsSecure = false, IsSessionRequired = false, RequestType = ViddlerRequestType.Get)]
  public class GetEmbedCodeTypes : Viddler.Data.VideoEmbedCodeTypeList
  {
  }
}
