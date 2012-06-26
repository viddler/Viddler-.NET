using System;
using System.Xml.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class StatisticsComments : DataObjectBase
  {
    /// <summary>
    /// posted
    /// </summary>
    [XmlElement(ElementName = "posted")]
    public int Posted
    {
      get;
      set;
    }

    /// <summary>
    /// received
    /// </summary>
    [XmlElement(ElementName = "received")]
    public int Received
    {
      get;
      set;
    }
  }
}
