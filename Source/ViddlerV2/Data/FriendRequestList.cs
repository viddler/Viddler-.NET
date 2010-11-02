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
  public class FriendRequestList : DataObjectBase
  {
    /// <summary>
    /// Initializes a new instance of data object class.
    /// </summary>
    public FriendRequestList()
    {
      this.Items = new List<FriendRequest>();
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "request"
    /// </summary>
    [XmlArray(ElementName = "friend_requests")]
    [XmlArrayItem(ElementName = "friend_request")]
    public List<FriendRequest> Items
    {
      get;
      set;
    }
  }
}
