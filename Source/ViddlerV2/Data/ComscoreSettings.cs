using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class ComscoreSettings : DataObjectBase
  {
    /// <summary>
    /// Corresponds to the remote Viddler API field "enabled"
    /// </summary>
    [XmlElement(ElementName = "enabled")]
    public bool? Enabled
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "distribution_platform"
    /// </summary>
    [XmlElement(ElementName = "distribution_platform")]
    public string DistributionPlatform
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "location"
    /// </summary>
    [XmlElement(ElementName = "location")]
    public string Location
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "owner"
    /// </summary>
    [XmlElement(ElementName = "owner")]
    public string Owner
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "segment_level_reporting"
    /// </summary>
    [XmlElement(ElementName = "segment_level_reporting")]
    public string SegmentLevelReporting
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "show_level_reporting"
    /// </summary>
    [XmlElement(ElementName = "show_level_reporting")]
    public string ShowLevelReporting
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "price"
    /// </summary>
    [XmlElement(ElementName = "price")]
    public double? Price
    {
      get;
      set;
    }
  }
}
