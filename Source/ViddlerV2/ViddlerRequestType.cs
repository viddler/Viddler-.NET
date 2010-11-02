using System;

namespace Viddler
{
  /// <summary>
  /// Provides enumerated values for the HTTP request method type.
  /// </summary>
  public enum ViddlerRequestType
  {
    /// <summary>
    /// HTTP GET method.
    /// </summary>
    Get,
    /// <summary>
    /// HTTP POST method.
    /// </summary>
    Post,
    /// <summary>
    /// HTTP POST method with content type set to "multipart/form-data".
    /// </summary>
    Multipart
  }
}
