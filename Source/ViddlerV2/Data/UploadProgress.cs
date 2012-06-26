using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class UploadProgress : DataObjectBase
  {
    /// <summary>
    /// Corresponds to the remote Viddler API field "status"
    /// </summary>
    [XmlElement(ElementName = "status")]
    public UploadStatus? Status
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "total_bytes"
    /// </summary>
    [XmlElement(ElementName = "total_bytes")]
    public long? TotalBytes
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "total_uploaded"
    /// </summary>
    [XmlElement(ElementName = "total_uploaded")]
    public long? TotalUploaded
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "percent"
    /// </summary>
    [XmlElement(ElementName = "percent")]
    public int? Percent
    {
      get;
      set;
    }
  }
}
