using System;
using System.Reflection;
using System.Collections.Specialized;

namespace Viddler
{
  /// <summary>
  /// Provides request parameters for Viddler API remote methods and contros XML serialization of the attribute target as an XML root element.
  /// </summary>
  [System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
  public sealed class ViddlerMethodAttribute : System.Xml.Serialization.XmlRootAttribute
  {
    /// <summary>
    /// Initializes a new instance of ViddlerMethodAttribute class.
    /// </summary>
    public ViddlerMethodAttribute()
    {
      this.MethodName = string.Empty;
      this.RequestType = ViddlerRequestType.Get;
    }

    /// <summary>
    /// Gets or sets remote Viddler API method name.
    /// </summary>
    public string MethodName
    {
      get;
      set;
    }

    /// <summary>
    /// Gets or sets a value indicating whether to use SSL protocol during the communication with remote Viddler API method.
    /// </summary>
    public bool IsSecure
    {
      get;
      set;
    }

    /// <summary>
    /// Gets or sets a value indicating whether the session identifier is required during the communication with remote Viddler API method.
    /// </summary>
    public bool IsSessionRequired
    {
      get;
      set;
    }

    /// <summary>
    /// Gets or sets a value representing HTTP method type used during the communication with remote Viddler API method.
    /// </summary>
    public ViddlerRequestType RequestType
    {
      get;
      set;
    }
  }
}
