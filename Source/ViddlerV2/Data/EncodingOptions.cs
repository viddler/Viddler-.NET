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
  public class EncodingOptions : DataObjectBase
  {
    /// <summary>
    /// Initializes a new instance of data object class.
    /// </summary>
    public EncodingOptions()
    {
      this.Items = new List<EncodingProfile>();
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "respect_source_dimensions"
    /// </summary>
    [XmlElement(ElementName = "respect_source_dimensions")]
    public bool? RespectSourceDimensions
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "preserve_source_flv_files"
    /// </summary>
    [XmlElement(ElementName = "preserve_source_flv_files")]
    public bool? PreserveSourceFlvFiles
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "profiles"
    /// </summary>
    [XmlArray(ElementName = "profiles")]
    [XmlArrayItem(ElementName = "profile")]
    public List<EncodingProfile> Items
    {
      get;
      set;
    }
  }
}
