using System;
using System.ComponentModel;

namespace ViddlerDemo
{
  [Serializable]
  internal class VideoListItem
  {
    internal VideoListItem(Viddler.Data.Video video)
    {
      this.Title = video.Title;
      this.Url = new Uri(video.Url);
      this.UploadTime = (video.UploadTime.HasValue) ? video.UploadTime.Value.DateTime : DateTime.MinValue;
      this.Author = video.Author;
      this.Description = video.Description;
      this.Id = video.Id;
      this.Status = video.Status.ToString();
      if (video.Permission != null)
      {
        if (video.Permission.View != null) this.SecurityView = video.Permission.View.Level.ToString();
        if (video.Permission.Download != null) this.SecurityDownload = video.Permission.Download.Level.ToString();
        if (video.Permission.Commenting != null) this.SecurityCommenting = video.Permission.Commenting.Level.ToString();
        if (video.Permission.Embed != null) this.SecurityEmbed = video.Permission.Embed.Level.ToString();
        if (video.Permission.Tagging != null) this.SecurityTagging = video.Permission.Tagging.Level.ToString();
        if (video.Permission.SecretUrl != null) this.SecretUrl = new Uri(video.Permission.SecretUrl);
      }
    }

    internal bool IsChanged
    {
      get;
      set;
    }

    [DisplayName("Title"), Category("General"), Description("Title of the video file.")]
    public string Title
    {
      get;
      set;
    }

    [DisplayName("File URL"), Category("General"), Description("URL of the video file.")]
    public Uri Url
    {
      get;
      private set;
    }

    [DisplayName("Upload time"), Category("General"), Description("Time of the video file upload.")]
    public DateTime UploadTime
    {
      get;
      private set;
    }

    [DisplayName("Author"), Category("General"), Description("Author of the video file.")]
    public string Author
    {
      get;
      private set;
    }

    [DisplayName("File ID"), Category("General"), Description("ID of the video file.")]
    public string Id
    {
      get;
      private set;
    }

    [DisplayName("Description"), Category("General"), Description("Description of the video file.")]
    public string Description
    {
      get;
      set;
    }

    [DisplayName("Status"), Category("General"), Description("Status of the video file.")]
    public string Status
    {
      get;
      private set;
    }

    [DisplayName("View"), Category("Permission"), Description("Permissions of the video file.")]
    public string SecurityView
    {
      get;
      private set;
    }

    [DisplayName("Download"), Category("Permission"), Description("Permissions of the video file.")]
    public string SecurityDownload
    {
      get;
      private set;
    }

    [DisplayName("Commenting"), Category("Permission"), Description("Permissions of the video file.")]
    public string SecurityCommenting
    {
      get;
      private set;
    }

    [DisplayName("Embed"), Category("Permission"), Description("Permissions of the video file.")]
    public string SecurityEmbed
    {
      get;
      private set;
    }

    [DisplayName("Tagging"), Category("Permission"), Description("Permissions of the video file.")]
    public string SecurityTagging
    {
      get;
      private set;
    }

    [DisplayName("Secret URL"), Category("Permission"), Description("Secrete URL of the video file.")]
    public Uri SecretUrl
    {
      get;
      private set;
    }

    public override string ToString()
    {
      return string.Concat(this.Title, " [", this.Id, "]");
    }
  }
}
