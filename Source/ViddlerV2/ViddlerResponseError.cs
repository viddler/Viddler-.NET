using System;
using System.Xml.Serialization;

namespace Viddler
{
  /// <summary>
  /// Represents the Viddler API error data sent by a remote server during HTTP request.
  /// </summary>
  [Serializable]
  [XmlRoot(ElementName = "error")]
  public sealed class ViddlerResponseError : Data.DataObjectBase
  {
    /// <summary>
    /// code
    /// </summary>
    [XmlElement(ElementName = "code")]
    public int Code
    {
      get;
      set;
    }

    /// <summary>
    /// description
    /// </summary>
    [XmlElement(ElementName = "description")]
    public string Description
    {
      get;
      set;
    }

    /// <summary>
    /// details
    /// </summary>
    [XmlElement(ElementName = "details")]
    public string Details
    {
      get;
      set;
    }
  }
}
