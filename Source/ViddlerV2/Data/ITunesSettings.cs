using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents a data object used to deserialize the remote Viddler API method result.
  /// </summary>
  [Serializable]
  public class ITunesSettings : DataObjectBase
  {
    /// <summary>
    /// Corresponds to the remote Viddler API field "status"
    /// </summary>
    [XmlElement(ElementName = "status")]
    public ITunesFeedStatus? Status
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "feed_url"
    /// </summary>
    [XmlElement(ElementName = "feed_url")]
    public string FeedUrl
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "author"
    /// </summary>
    [XmlElement(ElementName = "author")]
    public string Author
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "title"
    /// </summary>
    [XmlElement(ElementName = "title")]
    public string Title
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "keywords"
    /// </summary>
    [XmlElement(ElementName = "keywords")]
    public string Keywords
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "description"
    /// </summary>
    [XmlElement(ElementName = "description")]
    public string Description
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "image_url"
    /// </summary>
    [XmlElement(ElementName = "image_url")]
    public string ImageUrl
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "email"
    /// </summary>
    [XmlElement(ElementName = "email")]
    public string Email
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "lang"
    /// </summary>
    [XmlElement(ElementName = "lang")]
    public string Language
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "category_1"
    /// </summary>
    [XmlElement(ElementName = "category_1")]
    public string Category1
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "category_2"
    /// </summary>
    [XmlElement(ElementName = "category_2")]
    public string Category2
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "category_3"
    /// </summary>
    [XmlElement(ElementName = "category_3")]
    public string Category3
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "subtitle"
    /// </summary>
    [XmlElement(ElementName = "subtitle")]
    public string Subtitle
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "content_label"
    /// </summary>
    [XmlElement(ElementName = "content_label")]
    public string ContentLabel
    {
      get;
      set;
    }

    /// <summary>
    /// Corresponds to the remote Viddler API field "episodes_to_show"
    /// </summary>
    [XmlElement(ElementName = "episodes_to_show")]
    public int? EpisodesToShow
    {
      get;
      set;
    }
  }
}
