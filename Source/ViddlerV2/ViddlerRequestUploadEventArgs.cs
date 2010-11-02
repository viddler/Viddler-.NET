using System;
using System.Collections.Specialized;
using System.IO;

namespace Viddler
{
  /// <summary>
  /// Provides data for the generic EventHandler event.
  /// </summary>
  public sealed class ViddlerRequestUploadEventArgs : System.EventArgs
  {
    /// <summary/>
    private Type requestContractType;

    /// <summary/>
    private long totalBytes;

    /// <summary/>
    private long bytesSent;

    /// <summary>
    /// Initializes a new instance of ViddlerRequestUploadEventArgs class.
    /// </summary>
    internal ViddlerRequestUploadEventArgs(Type contractType, long totalBytes, long bytesSent)
    {
      this.requestContractType = contractType;
      this.totalBytes = totalBytes;
      this.bytesSent = bytesSent;
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
    /// Gets a size of a file being currently uploaded.
    /// </summary>
    public long TotalBytes
    {
      get
      {
        return this.totalBytes;
      }
    }

    /// <summary>
    /// Gets a number of bytes already sent.
    /// </summary>
    public long BytesSent
    {
      get
      {
        return this.bytesSent;
      }
    }

    /// <summary>
    /// Gets or sets a value indicating whether to abort the current upload process.
    /// </summary>
    public bool Cancel
    {
      get;
      set;
    }
  }
}
