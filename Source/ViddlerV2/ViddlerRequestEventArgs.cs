using System;
using System.Collections.Specialized;
using System.IO;

namespace Viddler
{
  /// <summary>
  /// Provides data for the generic EventHandler event.
  /// </summary>
  public class ViddlerRequestEventArgs : System.EventArgs
  {
    /// <summary/>
    private Type requestContractType;

    /// <summary/>
    private StringDictionary requestParameters;

    /// <summary/>
    private bool isRequestFile;

    /// <summary>
    /// Initializes a new instance of ViddlerRequestEventArgs class.
    /// </summary>
    internal ViddlerRequestEventArgs(Type contractType, StringDictionary parameters, bool isFile)
    {
      this.requestContractType = contractType;
      this.requestParameters = parameters;
      this.isRequestFile = isFile;
    }

    /// <summary>
    /// Gets a type of contract class used during a HTTP request.
    /// </summary>
    public Type ContractType
    {
      get
      {
        return this.requestContractType;
      }
    }

    /// <summary>
    /// Gets a collection of query parameters used during a HTTP request.
    /// </summary>
    public StringDictionary Parameters
    {
      get
      {
        return this.requestParameters;
      }
    }

    /// <summary>
    /// Gets a value indicating whether a file was sent during a HTTP request.
    /// </summary>
    public bool IsRequestFile
    {
      get
      {
        return this.isRequestFile;
      }
    }
  }
}
