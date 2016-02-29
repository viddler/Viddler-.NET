using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using Data = Viddler.Data;

namespace Viddler.Encoding
{
  /// <summary>
  /// Provides access to Viddler API methods located in viddler.encoding namespace.
  /// </summary>
  /// <remarks>Visit <a href="http://developers.viddler.com/" target="_blank">http://developers.viddler.com/</a> to get the full overview of methods contained in this class.</remarks>
  public sealed class EncodingNamespaceWrapper : ViddlerNamespaceProvider
  {
    /// <summary>
    /// Initializes a new instance of EncodingNamespaceWrapper class.
    /// </summary>
    internal EncodingNamespaceWrapper(ViddlerService service) : base(service)
    {
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.encoding.getStatus
    /// </summary>
    public Data.EncodingStatus GetStatus()
    {
      return this.Service.ExecuteHttpRequest<Encoding.GetStatus, Data.EncodingStatus>(null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.encoding.getStatus2
    /// </summary>
    public Data.VideoEncodingList GetStatus2(string videoId = null)
    {
        StringDictionary parameters = null;
        if (!string.IsNullOrEmpty(videoId))
        {
            parameters = new StringDictionary();
            parameters.Add("video_id", videoId);
        }
        return this.Service.ExecuteHttpRequest<Encoding.GetStatus2, Data.VideoEncodingList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.encoding.encode
    /// </summary>
    public Data.VideoFileEncoding Encode(string videoId, int profileId)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("video_id", videoId);
      parameters.Add("profile_id", profileId.ToString(CultureInfo.InvariantCulture));

      return this.Service.ExecuteHttpRequest<Encoding.Encode, Data.VideoFileEncoding>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.encoding.cancel
    /// </summary>
    public Data.VideoEncodingList Cancel(string fileId)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("file_id", fileId);

      return this.Service.ExecuteHttpRequest<Encoding.Cancel, Data.VideoEncodingList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.encoding.getSettings
    /// </summary>
    public Data.EncodingSettings GetSettings()
    {
      return this.Service.ExecuteHttpRequest<Encoding.GetSettings, Data.EncodingSettings>(null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.encoding.setSettings
    /// </summary>
    public Data.EncodingSettings SetSettings(bool useSourceForPlayback)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("use_source_for_playback", useSourceForPlayback ? "1" : "0");

      return this.Service.ExecuteHttpRequest<Encoding.SetSettings, Data.EncodingSettings>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.encoding.setSettings
    /// </summary>
    public Data.EncodingSettings SetSettings(int profileId, int profileBitrate)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add(string.Concat("profile_", profileId, "_bitrate"), profileBitrate.ToString(CultureInfo.InvariantCulture));

      return this.Service.ExecuteHttpRequest<Encoding.SetSettings, Data.EncodingSettings>(parameters);
    }
  }
}