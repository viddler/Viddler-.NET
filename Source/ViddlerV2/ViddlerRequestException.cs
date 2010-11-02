using System;
using System.Collections.Generic;
using System.Text;

namespace Viddler
{
  /// <summary>
  /// The exception which occurs when ViddlerService throws an error during a HTTP request.
  /// </summary>
  [Serializable]
  public sealed class ViddlerRequestException : Exception
  {
    /// <summary/>
    private int code;

    /// <summary/>
    private string details;

    /// <summary/>
    private string description;

    /// <summary>
    /// Initializes a new instance of ViddlerRequestException class.
    /// </summary>
    internal ViddlerRequestException(ViddlerResponseError error, Exception innerException)
      : base(string.Concat(error.Code, " - ", error.Description, ": ", error.Details), innerException)
    {
      this.code = error.Code;
      this.details = error.Details;
      this.description = error.Description;
    }

    /// <summary>
    /// Gets a code of Viddler error.
    /// </summary>
    public int Code
    {
      get
      {
        return this.code;
      }
    }

    /// <summary>
    /// Gets details of Viddler error.
    /// </summary>
    public string Details
    {
      get
      {
        return this.details;
      }
    }

    /// <summary>
    /// Gets a description of Viddler error.
    /// </summary>
    public string Description
    {
      get
      {
        return this.description;
      }
    }
  }
}
