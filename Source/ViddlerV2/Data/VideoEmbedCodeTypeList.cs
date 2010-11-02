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
  public class VideoEmbedCodeTypeList : DataObjectBase
  {
    /// <summary>
    /// Initializes a new instance of data object class.
    /// </summary>
    public VideoEmbedCodeTypeList()
    {
      this.Items = new List<VideoEmbedCodeType>();
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "embed_code_types"
    /// </summary>
    [XmlArray(ElementName = "embed_code_types")]
    [XmlArrayItem(ElementName = "embed_code_type")]
    public List<VideoEmbedCodeType> Items
    {
      get;
      set;
    }
  }
}
