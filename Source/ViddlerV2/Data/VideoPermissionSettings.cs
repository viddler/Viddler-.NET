using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class VideoPermissionSettings : DataObjectBase
  {
    /// <summary>
    /// Initializes a new instance of data object class.
    /// </summary>
    public VideoPermissionSettings()
    {
      this.View = new VideoPermission();
      this.Embed = new VideoPermission();
      this.Tagging = new VideoPermission();
      this.Commenting = new VideoPermission();
      this.Download = new VideoPermission();
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "secreturl"
    /// </summary>
    [XmlElement(ElementName = "secreturl")]
    public string SecretUrl
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "view"
    /// </summary>
    [XmlElement(ElementName = "view")]
    public VideoPermission View
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "embed"
    /// </summary>
    [XmlElement(ElementName = "embed")]
    public VideoPermission Embed
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "tagging"
    /// </summary>
    [XmlElement(ElementName = "tagging")]
    public VideoPermission Tagging
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "commenting"
    /// </summary>
    [XmlElement(ElementName = "commenting")]
    public VideoPermission Commenting
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "download"
    /// </summary>
    [XmlElement(ElementName = "download")]
    public VideoPermission Download
    {
      get;
      set;
    }
  }
}
