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
  public class EncodingSettings : DataObjectBase
  {
    /// <summary>
    /// Initializes a new instance of data object class.
    /// </summary>
    public EncodingSettings()
    {
      this.Items = new List<EncodingProfile>();
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "use_source_for_playback"
    /// </summary>
    [XmlElement(ElementName = "use_source_for_playback")]
    public bool? UseSourceForPlayback
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "profiles"
    /// </summary>
    [XmlArray(ElementName = "encoding_profiles")]
    [XmlArrayItem(ElementName = "profile")]
    public List<EncodingProfile> Items
    {
      get;
      set;
    }
  }
}
