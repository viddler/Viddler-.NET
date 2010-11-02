using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using Data = Viddler.Data;

namespace Viddler.Api
{
  /// <summary>
  /// Provides access to Viddler API methods located in viddler.api namespace.
  /// </summary>
  /// <remarks>Visit <a href="http://developers.viddler.com/" target="_blank">http://developers.viddler.com/</a> to get the full overview of methods contained in this class.</remarks>
  public sealed class ApiNamespaceWrapper : ViddlerNamespaceProvider
  {
    /// <summary>
    /// Initializes a new instance of ApiNamespaceWrapper class.
    /// </summary>
    internal ApiNamespaceWrapper(ViddlerService service)
      : base(service)
    {
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.api.echo
    /// </summary>
    public string Echo(string message)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("message", message);

      Data.EchoMessage responseObject = this.Service.ExecuteHttpRequest<Api.Echo, Data.EchoMessage>(parameters);
      return (responseObject != null) ? responseObject.Message : null;
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.api.getInfo
    /// </summary>
    public string GetVersion()
    {
      Data.ApiInfo responseObject = this.Service.ExecuteHttpRequest<Api.GetInfo, Data.ApiInfo>(null);
      return (responseObject != null) ? responseObject.Version : null;
    }
  }
}
