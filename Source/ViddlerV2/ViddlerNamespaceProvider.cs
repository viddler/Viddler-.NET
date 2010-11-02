using System;
using System.Collections.Generic;
using System.Text;

namespace Viddler
{
  /// <summary>
  /// When inherited in a derived class, provides access to Viddler API methods located in the specified Viddler API namespace.
  /// </summary>
  /// <remarks>
  /// This class is not intended to be used in your code in any way.
  /// </remarks>
  public abstract class ViddlerNamespaceProvider
  {
    /// <summary/>
    private ViddlerService service;

    /// <summary>
    /// Initializes a new instance of ViddlerNamespaceProvider class.
    /// </summary>
    internal ViddlerNamespaceProvider(ViddlerService service)
    {
      this.service = service;
    }

    /// <summary>
    /// Provides access to an instance of ViddlerService in derived classes.
    /// </summary>
    protected ViddlerService Service
    {
      get {
        return this.service;
      }
    }
  }
}
