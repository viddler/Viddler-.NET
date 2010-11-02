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
    internal EncodingNamespaceWrapper(ViddlerService service)
      : base(service)
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
    /// Calls the remote Viddler API method: viddler.encoding.encode
    /// </summary>
    public Data.EncodingStatus Encode(string videoId, int profileId)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("video_id", videoId);
      parameters.Add("profile_id", profileId.ToString(CultureInfo.InvariantCulture));

      return this.Service.ExecuteHttpRequest<Encoding.Encode, Data.EncodingStatus>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.encoding.cancel
    /// </summary>
    public Data.EncodingStatus Cancel(string fileId)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("file_id", fileId);

      return this.Service.ExecuteHttpRequest<Encoding.Cancel, Data.EncodingStatus>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.encoding.getOptions
    /// </summary>
    public Data.EncodingOptions GetOptions()
    {
      return this.Service.ExecuteHttpRequest<Encoding.GetOptions, Data.EncodingOptions>(null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.encoding.setOptions
    /// </summary>
    public Data.EncodingOptions SetOptions(bool? respectSourceDimensions, bool? preserveSourceFlvFiles)
    {
      StringDictionary parameters = new StringDictionary();
      if (respectSourceDimensions.HasValue) parameters.Add("respect_source_dimensions", respectSourceDimensions.Value ? "1" : "0");
      if (preserveSourceFlvFiles.HasValue) parameters.Add("preserve_source_flv_files", preserveSourceFlvFiles.Value ? "1" : "0");

      return this.Service.ExecuteHttpRequest<Encoding.SetOptions, Data.EncodingOptions>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.encoding.setOptions
    /// </summary>
    public Data.EncodingOptions SetOptions(int profileId, bool? profileEnabled, int? profileBitrate)
    {
      StringDictionary parameters = new StringDictionary();
      if (profileEnabled.HasValue) parameters.Add(string.Concat("profile_", profileId, "_enabled"), profileEnabled.Value ? "1" : "0");
      if (profileBitrate.HasValue) parameters.Add(string.Concat("profile_", profileId, "_bitrate"), profileBitrate.Value.ToString(CultureInfo.InvariantCulture));

      return this.Service.ExecuteHttpRequest<Encoding.SetOptions, Data.EncodingOptions>(parameters);
    }
  }
}
