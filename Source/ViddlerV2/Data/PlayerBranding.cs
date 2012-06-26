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
  public class PlayerBranding : DataObjectBase
  {
    /// <summary>
    /// Corresponds to the remote Viddler API field "logo_url"
    /// </summary>
    [XmlElement(ElementName = "logo_url")]
    public string LogoUrl
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "logo_click_url"
    /// </summary>
    [XmlElement(ElementName = "logo_click_url")]
    public string LogoClickUrl
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "logo_width"
    /// </summary>
    [XmlElement(ElementName = "logo_width")]
    public int? LogoWidth
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "logo_height"
    /// </summary>
    [XmlElement(ElementName = "logo_height")]
    public int? LogoHeight
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "logo_visible"
    /// </summary>
    [XmlElement(ElementName = "logo_visible")]
    public bool? LogoVisible
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "logo_flash_version"
    /// </summary>
    [XmlElement(ElementName = "logo_flash_version")]
    public bool? LogoFlashVersion
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "logo_offset_x"
    /// </summary>
    [XmlElement(ElementName = "logo_offset_x")]
    public int? LogoOffsetX
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "logo_offset_y"
    /// </summary>
    [XmlElement(ElementName = "logo_offset_y")]
    public int? LogoOffsetY
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "logo_align"
    /// </summary>
    [XmlElement(ElementName = "logo_align")]
    public ImageAlignmentType? LogoAlign
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "shade_dark"
    /// </summary>
    [XmlElement(ElementName = "shade_dark")]
    public bool? ShadeDark
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "advanced_options"
    /// </summary>
    [XmlElement(ElementName = "advanced_options")]
    public bool? AdvancedOptions
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "simple_color"
    /// </summary>
    [XmlElement(ElementName = "simple_color")]
    public string SimpleColor
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "control_bar"
    /// </summary>
    [XmlElement(ElementName = "control_bar")]
    public string ControlBar
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "bhover"
    /// </summary>
    [XmlElement(ElementName = "bhover")]
    public string BHover
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "bidle"
    /// </summary>
    [XmlElement(ElementName = "bidle")]
    public string BIdle
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "bclicked"
    /// </summary>
    [XmlElement(ElementName = "bclicked")]
    public string BClicked
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "pidle"
    /// </summary>
    [XmlElement(ElementName = "pidle")]
    public string PIdle
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "phover"
    /// </summary>
    [XmlElement(ElementName = "phover")]
    public string PHover
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "pclicked"
    /// </summary>
    [XmlElement(ElementName = "pclicked")]
    public string PClicked
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "timeplayed"
    /// </summary>
    [XmlElement(ElementName = "timeplayed")]
    public string TimePlayed
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "timeloaded"
    /// </summary>
    [XmlElement(ElementName = "timeloaded")]
    public string TimeLoaded
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "timebackground"
    /// </summary>
    [XmlElement(ElementName = "timebackground")]
    public string TimeBackground
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "enable_stripes"
    /// </summary>
    [XmlElement(ElementName = "enable_stripes")]
    public bool? EnableStripes
    {
      get;
      set;
    }
  }
}
