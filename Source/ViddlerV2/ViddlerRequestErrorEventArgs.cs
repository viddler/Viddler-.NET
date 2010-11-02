using System;
using System.Collections.Specialized;
using System.IO;

namespace Viddler
{
  /// <summary>
  /// Provides data for the generic EventHandler event.
  /// </summary>
  public class ViddlerRequestErrorEventArgs : ViddlerRequestEventArgs
  {
    /// <summary/>
    private Exception exception;

    /// <summary>
    /// Initializes a new instance of ViddlerRequestErrorEventArgs class.
    /// </summary>
    internal ViddlerRequestErrorEventArgs(Type contractType, StringDictionary parameters, bool isFile, Exception exception)
      : base(contractType, parameters, isFile)
    {
      this.exception = exception;
    }

    /// <summary>
    /// Gets a system exception thrown during a HTTP request.
    /// </summary>
    public Exception Exception
    {
      get
      {
        return this.exception;
      }
    }
  }
}
