using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class EncodingStatus : DataObjectBase
  {
    /// <summary>
    /// Initializes a new instance of data object class.
    /// </summary>
    public EncodingStatus()
    {
      this.Items = new List<VideoFile>();
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "files"
    /// </summary>
    [XmlArray(ElementName = "files")]
    [XmlArrayItem(ElementName = "file")]
    public List<VideoFile> Items
    {
      get;
      set;
    }
  }
}
