using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class PermissionSettings : DataObjectBase
  {
    /// <summary>
    /// Initializes a new instance of data object class.
    /// </summary>
    public PermissionSettings()
    {
      this.View = new Permission();
      this.Embed = new Permission();
      this.Tagging = new Permission();
      this.Commenting = new Permission();
      this.Download = new Permission();
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
    public Permission View
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "embed"
    /// </summary>
    [XmlElement(ElementName = "embed")]
    public Permission Embed
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "tagging"
    /// </summary>
    [XmlElement(ElementName = "tagging")]
    public Permission Tagging
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "commenting"
    /// </summary>
    [XmlElement(ElementName = "commenting")]
    public Permission Commenting
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "download"
    /// </summary>
    [XmlElement(ElementName = "download")]
    public Permission Download
    {
      get;
      set;
    }
  }
}
