using System;
using System.Xml.Serialization;

namespace Viddler
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method "general success" result.
  /// </summary>
  [Serializable]
  [XmlRoot(ElementName = "success")]
  public class ViddlerResponseSuccess : Data.DataObjectBase
  {
    /// <summary>
    /// isSuccess
    /// </summary>
    [XmlIgnore]
    public bool IsSuccess
    {
      get
      {
        return true;
      }
    }
  }
}
