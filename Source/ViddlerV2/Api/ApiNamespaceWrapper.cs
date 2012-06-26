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
    internal ApiNamespaceWrapper(ViddlerService service) : base(service)
    {
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.api.echo
    /// </summary>
    public Data.EchoMessage Echo(string message)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("message", message);

      return this.Service.ExecuteHttpRequest<Api.Echo, Data.EchoMessage>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.api.getInfo
    /// </summary>
    public Data.ApiInfo GetInfo()
    {
      return this.Service.ExecuteHttpRequest<Api.GetInfo, Data.ApiInfo>(null);
    }
  }
}