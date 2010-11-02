using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.Net;
using System.IO;
using System.Text;
using System.Globalization;

namespace Viddler
{
  /// <summary>
  /// Provides a way to handle HTTP requests to the remote Viddler API methods.
  /// </summary>
  /// <example>
  /// Using ViddlerService class:
  /// <code>
  /// <![CDATA[
  /// namespace ViddlerConsole
  /// {
  ///   class Program
  ///   {
  ///     static void Main(string[] args)
  ///     {
  ///       // Create a new instance of the Viddler service, which handles execution of all methods
  ///       Viddler.ViddlerService service =
  ///         new Viddler.ViddlerService(
  ///           "http://api.viddler.com/api/v2/",
  ///           "https://api.viddler.com/api/v2/",
  ///           "xxxxxxxxxxxxxxxxxxxx");
  /// 
  ///       // Handle events, which occurr while HTTP requests to the remote service begin
  ///       service.BeginRequest += new System.EventHandler<Viddler.ViddlerRequestEventArgs>(service_BeginRequest);
  /// 
  ///       // Handle events, which occurr while HTTP requests to the remote service end
  ///       service.EndRequest += new System.EventHandler<Viddler.ViddlerRequestEventArgs>(service_EndRequest);
  /// 
  ///       // Handle exceptions thrown by service
  ///       service.Error += new System.EventHandler<Viddler.ViddlerRequestErrorEventArgs>(service_Error);
  /// 
  ///       // Handle file upload progress
  ///       service.Uploading += new System.EventHandler<Viddler.ViddlerRequestUploadEventArgs>(service_Uploading);
  /// 
  ///       // Authenticate some user
  ///       Viddler.Data.UserSession session = service.Users.Auth("someUserName", "someSecretPassword");
  ///       if (session != null)
  ///       {
  ///         System.Console.WriteLine("Session ID: {0}", session.SessionId);
  ///         System.Console.WriteLine();
  ///       }
  /// 
  ///       // Get a collection of videos
  ///       Viddler.Data.VideoList videoList = service.Videos.GetByUser();
  ///       if (videoList != null && videoList.Items != null)
  ///       {
  ///         System.Console.WriteLine("Videos ({0} items):", videoList.Items.Count);
  ///         System.Console.WriteLine();
  /// 
  ///         // Iterate through the video collection items
  ///         foreach (Viddler.Data.Video video in videoList.Items)
  ///         {
  ///           System.Console.WriteLine(video.Title);
  ///           System.Console.WriteLine(video.Url);
  ///           System.Console.WriteLine();
  ///         }
  ///       }
  /// 
  ///       // Upload a new video file
  ///       Viddler.Data.Video newVideo = service.Videos.Upload(
  ///         "New file",
  ///         "sample,test",
  ///         "My new file",
  ///         true,
  ///         @"c:\MyNewVideo.mpg",
  ///         true);
  ///       if (newVideo != null && newVideo.Status.HasValue)
  ///       {
  ///         System.Console.WriteLine("Status: {0}", newVideo.Status.Value);
  ///         System.Console.WriteLine();
  ///       }
  ///       System.Console.Read();
  ///     }
  /// 
  ///     static void service_BeginRequest(object sender, Viddler.ViddlerRequestEventArgs e)
  ///     {
  ///       System.Console.WriteLine("BeginRequest: {0}", e.ContractType);
  ///       System.Console.WriteLine();
  ///     }
  /// 
  ///     static void service_EndRequest(object sender, Viddler.ViddlerRequestEventArgs e)
  ///     {
  ///       System.Console.WriteLine("EndRequest: {0}", e.ContractType);
  ///       System.Console.WriteLine();
  ///     }
  /// 
  ///     static void service_Error(object sender, Viddler.ViddlerRequestErrorEventArgs e)
  ///     {
  ///       System.Console.WriteLine("Error: {0}", e.Exception.Message);
  ///       System.Console.WriteLine();
  ///     }
  /// 
  ///     static void service_Uploading(object sender, Viddler.ViddlerRequestUploadEventArgs e)
  ///     {
  ///       System.Console.WriteLine("Uploading: {0} of {1} bytes sent", e.BytesSent, e.TotalBytes);
  ///       System.Console.WriteLine();
  ///     }
  ///   }
  /// }
  /// ]]>
  /// </code>
  /// </example>
  public sealed class ViddlerService
  {
    #region Fields

    /// <summary/>
    private Videos.VideosNamespaceWrapper videos;

    /// <summary/>
    private Users.UsersNamespaceWrapper users;

    /// <summary/>
    private Api.ApiNamespaceWrapper api;

    /// <summary/>
    private Encoding.EncodingNamespaceWrapper encoding;

    /// <summary/>
    private Groups.GroupsNamespaceWrapper groups;

    /// <summary/>
    private Playlists.PlaylistsNamespaceWrapper playLists;

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance of ViddlerService class, which provides a way to handle HTTP requests to the remote Viddler API methods.
    /// </summary>
    /// <remarks>Provide valid base URL, secure base URL and API key by setting .config file or by passing them manually to this instance.</remarks>
    public ViddlerService()
    {
      ViddlerConfigurationSection settings = ViddlerConfigurationSection.Instance;
      if (settings != null)
      {
        this.BaseUrl = settings.BaseUrl;
        this.SecureBaseUrl = settings.SecureBaseUrl;
        this.ApiKey = settings.ApiKey;
        this.EnableSsl = settings.EnableSsl;
      }
    }

    /// <summary>
    /// Initializes a new instance of ViddlerService class, which provides a way to handle HTTP requests to the remote Viddler API methods.
    /// </summary>
    /// <remarks>Provide valid base URL, secure base URL and API key by setting .config file or by passing them manually to this instance.</remarks>
    public ViddlerService(string baseUrl, string secureBaseUrl, string apiKey)
    {
      this.BaseUrl = baseUrl;
      this.SecureBaseUrl = secureBaseUrl;
      this.ApiKey = apiKey;
      this.EnableSsl = !string.IsNullOrEmpty(this.SecureBaseUrl);
    }

    #endregion

    #region Public properties

    /// <summary>
    /// Provides access to Viddler API methods located in viddler.playlists namespace.
    /// </summary>
    public Playlists.PlaylistsNamespaceWrapper Playlists
    {
      get
      {
        if (this.playLists == null)
        {
          this.playLists = new Playlists.PlaylistsNamespaceWrapper(this);
        }
        return this.playLists;
      }
    }

    /// <summary>
    /// Provides access to Viddler API methods located in viddler.groups namespace.
    /// </summary>
    public Groups.GroupsNamespaceWrapper Groups
    {
      get
      {
        if (this.groups == null)
        {
          this.groups = new Groups.GroupsNamespaceWrapper(this);
        }
        return this.groups;
      }
    }

    /// <summary>
    /// Provides access to Viddler API methods located in viddler.encoding namespace.
    /// </summary>
    public Encoding.EncodingNamespaceWrapper Encoding
    {
      get
      {
        if (this.encoding == null)
        {
          this.encoding = new Encoding.EncodingNamespaceWrapper(this);
        }
        return this.encoding;
      }
    }

    /// <summary>
    /// Provides access to Viddler API methods located in viddler.api namespace.
    /// </summary>
    public Api.ApiNamespaceWrapper Api
    {
      get
      {
        if (this.api == null)
        {
          this.api = new Api.ApiNamespaceWrapper(this);
        }
        return this.api;
      }
    }

    /// <summary>
    /// Provides access to Viddler API methods located in viddler.videos namespace.
    /// </summary>
    public Videos.VideosNamespaceWrapper Videos
    {
      get
      {
        if (this.videos == null)
        {
          this.videos = new Videos.VideosNamespaceWrapper(this);
        }
        return this.videos;
      }
    }

    /// <summary>
    /// Provides access to Viddler API methods located in viddler.users namespace.
    /// </summary>
    public Users.UsersNamespaceWrapper Users
    {
      get
      {
        if (this.users == null)
        {
          this.users = new Users.UsersNamespaceWrapper(this);
        }
        return this.users;
      }
    }

    /// <summary>
    /// Gets or sets session identifier, which is being used to hadle personalized request.
    /// </summary>
    /// <remarks>The session identifier can be set either manually or automatically by calling Auth method located in viddler.users namespace.</remarks>
    public string SessionId
    {
      get;
      set;
    }

    /// <summary>
    /// Gets or sets Viddler API key.
    /// </summary>
    public string ApiKey
    {
      get;
      set;
    }

    /// <summary>
    /// Gets or sets a base HTTP URL for the remote Viddler API methods.
    /// </summary>
    public string BaseUrl
    {
      get;
      set;
    }

    /// <summary>
    /// Gets or sets a base HTTPS URL for the remote Viddler API methods.
    /// </summary>
    public string SecureBaseUrl
    {
      get;
      set;
    }

    /// <summary>
    /// Gets or sets a value indicating whether to use SecureBaseUrl.
    /// </summary>
    public bool EnableSsl
    {
      get;
      set;
    }

    /// <summary>
    /// Gets a value indicating whether session identifier has been set.
    /// </summary>
    public bool IsAuthenticated
    {
      get
      {
        return !string.IsNullOrEmpty(this.SessionId);
      }
    }

    #endregion

    #region Event handlers

    /// <summary>
    /// Occurs before a remote API method request is started.
    /// </summary>
    public event System.EventHandler<ViddlerRequestEventArgs> BeginRequest;

    /// <summary>
    /// Occurs when a remote API method request has been successfully completed.
    /// </summary>
    public event System.EventHandler<ViddlerRequestEventArgs> EndRequest;

    /// <summary>
    /// Occurs when an exception is thrown during communication with remote API method.
    /// </summary>
    public event System.EventHandler<ViddlerRequestErrorEventArgs> Error;

    /// <summary>
    /// Occurs when a file stream is being sent to the remote Viddler service.
    /// </summary>
    public event System.EventHandler<ViddlerRequestUploadEventArgs> Uploading;

    #endregion

    #region Request handling

    /// <summary>
    /// Remote API method execution.
    /// </summary>
    internal DataType ExecuteHttpRequest<ContractType, DataType>(StringDictionary parameters)
    {
      return this.ExecuteHttpRequest<ContractType, DataType>(parameters, null, null, null);
    }

    /// <summary>
    /// Remote API method execution.
    /// </summary>
    internal DataType ExecuteHttpRequest<ContractType, DataType>(StringDictionary parameters, string fileName, Stream fileStream, Data.UploadEndPoint endPoint)
    {
      ViddlerMethodAttribute methodAttribute = ViddlerHelper.GetMethodAttribute(typeof(ContractType));

      DataType responseObject = default(DataType);

      try
      {
        if (methodAttribute == null) throw new System.InvalidOperationException(string.Concat("ViddlerMethodAttribute missing for type \"", typeof(ContractType).ToString(), "\"."));

        if (this.BeginRequest != null)
        {
          this.BeginRequest(this, new ViddlerRequestEventArgs(typeof(ContractType), parameters, (fileStream != null)));
        }

        if (methodAttribute.IsSessionRequired && !this.IsAuthenticated) throw new System.InvalidOperationException("The current method requires authenticated user.");
        if (fileStream != null && !fileStream.CanSeek) throw new System.ArgumentException("The file stream does not support seeking.", "fileStream");

        switch (methodAttribute.RequestType)
        {
          case ViddlerRequestType.Post:
            {
              responseObject = this.ExecutePostHttpRequest<ContractType, DataType>(methodAttribute, parameters);
              break;
            }
          case ViddlerRequestType.Multipart:
            {
              responseObject = this.ExecuteMultipartHttpRequest<ContractType, DataType>(methodAttribute, parameters, fileName, fileStream, endPoint);
              break;
            }
          default:
            {
              responseObject = this.ExecuteGetHttpRequest<ContractType, DataType>(methodAttribute, parameters);
              break;
            }
        }

        if (this.EndRequest != null)
        {
          this.EndRequest(this, new ViddlerRequestEventArgs(typeof(ContractType), parameters, (fileStream != null)));
        }


      }
      catch (Exception exception)
      {
        if (this.Error != null)
        {
          this.Error(this, new ViddlerRequestErrorEventArgs(typeof(ContractType), parameters, (fileStream != null), exception));
        }
        else
        {
          throw;
        }
      }

      return responseObject;
    }

    #endregion

    #region Private members

    /// <summary>
    /// Remote API method execution using HTTP "post" method with content type set to "multipart/form-data". 
    /// </summary>
    private DataType ExecuteMultipartHttpRequest<ContractType, DataType>(ViddlerMethodAttribute methodAttribute, StringDictionary parameters, string fileName, Stream fileStream, Data.UploadEndPoint endPoint)
    {
      StringBuilder requestPath = new StringBuilder();
      if (endPoint != null && !string.IsNullOrEmpty(endPoint.Url))
      {
        requestPath.Append(endPoint.Url);
      }
      else
      {
        requestPath.Append((this.EnableSsl && methodAttribute.IsSecure) ? this.SecureBaseUrl : this.BaseUrl);
        requestPath.Append(methodAttribute.MethodName);
        requestPath.Append(".xml");
      }

      string boundary = string.Concat("-------------------------", DateTime.Now.Ticks.ToString("x", CultureInfo.InvariantCulture));
      byte[] boundaryBytes = System.Text.Encoding.UTF8.GetBytes(string.Concat("\r\n--", boundary, "\r\n"));
      byte[] endBoundaryBytes = System.Text.Encoding.UTF8.GetBytes(string.Concat("\r\n--", boundary, "--\r\n"));

      List<byte> requestData = new List<byte>();
      requestData.AddRange(boundaryBytes);
      requestData.AddRange(System.Text.Encoding.UTF8.GetBytes(string.Format(CultureInfo.InvariantCulture, "Content-Disposition: form-data; name=\"key\"\r\n\r\n{0}", this.ApiKey)));
      if (methodAttribute.IsSessionRequired)
      {
        requestData.AddRange(boundaryBytes);
        requestData.AddRange(System.Text.Encoding.UTF8.GetBytes(string.Format(CultureInfo.InvariantCulture, "Content-Disposition: form-data; name=\"sessionid\"\r\n\r\n{0}", this.SessionId)));
      }
      if (endPoint != null && !string.IsNullOrEmpty(endPoint.Token))
      {
        requestData.AddRange(boundaryBytes);
        requestData.AddRange(System.Text.Encoding.UTF8.GetBytes(string.Format(CultureInfo.InvariantCulture, "Content-Disposition: form-data; name=\"token\"\r\n\r\n{0}", endPoint.Token)));
      }

      if (parameters != null && parameters.Keys.Count > 0)
      {
        foreach (string key in parameters.Keys)
        {
          //string queryData = string.Format(CultureInfo.InvariantCulture, "Content-Disposition: form-data; name=\"{0}\"\r\n\r\n{1}", key, ViddlerHelper.EncodeRequestData(parameters[key]));
          string queryData = string.Format(CultureInfo.InvariantCulture, "Content-Disposition: form-data; name=\"{0}\"\r\n\r\n{1}", key, parameters[key]);
          requestData.AddRange(boundaryBytes);
          requestData.AddRange(System.Text.Encoding.UTF8.GetBytes(queryData));
        }
      }

      long fileSize = endBoundaryBytes.Length;
      if (fileStream != null)
      {
        string mimeType = ViddlerHelper.GetMimeType(fileStream);
        fileStream.Position = 0;
        if (string.IsNullOrEmpty(fileName))
        {
          fileName = DateTime.Now.Ticks.ToString("x", CultureInfo.InvariantCulture);
        }
        requestData.AddRange(boundaryBytes);
        //requestData.AddRange(System.Text.Encoding.UTF8.GetBytes(string.Format(CultureInfo.InvariantCulture, "Content-Disposition: form-data; name=\"file\"; filename=\"{0}\"\r\nContent-Type: {1}\r\n\r\n", ViddlerHelper.EncodeRequestData(fileName), mimeType)));
        requestData.AddRange(System.Text.Encoding.UTF8.GetBytes(string.Format(CultureInfo.InvariantCulture, "Content-Disposition: form-data; name=\"file\"; filename=\"{0}\"\r\nContent-Type: {1}\r\n\r\n", fileName, mimeType)));
        fileSize += fileStream.Length;
      }

      try
      {

        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestPath.ToString());
        request.Method = "POST";
        request.ContentType = string.Concat("multipart/form-data; boundary=", boundary);
        request.UserAgent = string.Concat("Microsoft .NET, ", this.GetType().Assembly.FullName);
        request.AllowWriteStreamBuffering = false;
        request.Accept = "text/xml";
        request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
        request.KeepAlive = true;
        request.Timeout = int.MaxValue;
        request.ReadWriteTimeout = int.MaxValue;
        request.ContentLength = requestData.Count + fileSize;

        Stream requestStream = request.GetRequestStream();
        bool isCancel = false;
        try
        {
          requestStream.Write(requestData.ToArray(), 0, requestData.Count);
          requestStream.Flush();
          if (fileStream != null)
          {
            byte[] buffer = new byte[32768];
            int bytesRead = 0;
            while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
            {
              requestStream.Write(buffer, 0, bytesRead);
              requestStream.Flush();
              if (this.Uploading != null)
              {
                ViddlerRequestUploadEventArgs uploadEventArgs = new ViddlerRequestUploadEventArgs(typeof(ContractType), fileStream.Length, fileStream.Position);
                this.Uploading(this, uploadEventArgs);
                if (uploadEventArgs.Cancel)
                {
                  isCancel = true;
                  request.Abort();
                  break;
                }
              }
            }
          }
          if (!isCancel)
          {
            requestStream.Write(endBoundaryBytes, 0, endBoundaryBytes.Length);
            requestStream.Flush();
          }
        }
        finally
        {
          if (!isCancel) requestStream.Dispose();
        }
        if (isCancel)
        {
          return default(DataType);
        }
        else
        {
          DataType responseObject = ViddlerService.HandleHttpResponse<ContractType, DataType>(request, methodAttribute);
          return responseObject;
        }
      }
      catch (System.Net.WebException exception)
      {
        throw ViddlerService.HandleHttpError(exception);
      }
    }

    /// <summary>
    /// Remote API method execution using HTTP "post" method. 
    /// </summary>
    private DataType ExecutePostHttpRequest<ContractType, DataType>(ViddlerMethodAttribute methodAttribute, StringDictionary parameters)
    {
      StringBuilder requestPath = new StringBuilder();
      StringBuilder requestData = new StringBuilder();
      requestPath.Append((this.EnableSsl && methodAttribute.IsSecure) ? this.SecureBaseUrl : this.BaseUrl);
      requestPath.Append(methodAttribute.MethodName);
      requestPath.Append(".xml");

      requestData.Append("key=");
      requestData.Append(this.ApiKey);
      if (methodAttribute.IsSessionRequired)
      {
        requestData.Append("&sessionid=");
        requestData.Append(this.SessionId);
      }

      if (parameters != null && parameters.Keys.Count > 0)
      {
        foreach (string key in parameters.Keys)
        {
          requestData.Append("&");
          requestData.Append(key);
          requestData.Append("=");
          requestData.Append(ViddlerHelper.EncodeRequestData(parameters[key]));
        }
      }
      byte[] postDataBytes = System.Text.Encoding.UTF8.GetBytes(requestData.ToString());

      try
      {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestPath.ToString());
        request.Method = "POST";
        request.ContentType = "application/x-www-form-urlencoded";
        request.UserAgent = string.Concat("Microsoft .NET, ", this.GetType().Assembly.FullName);
        request.AllowWriteStreamBuffering = true;
        request.Accept = "text/xml";
        request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
        request.KeepAlive = true;
        request.Timeout = int.MaxValue;
        request.ReadWriteTimeout = int.MaxValue;

        using (Stream requestStream = request.GetRequestStream())
        {
          requestStream.Write(postDataBytes, 0, postDataBytes.Length);
          requestStream.Flush();
        }

        DataType responseObject = ViddlerService.HandleHttpResponse<ContractType, DataType>(request, methodAttribute);
        return responseObject;
      }
      catch (System.Net.WebException exception)
      {
        throw ViddlerService.HandleHttpError(exception);
      }
    }

    /// <summary>
    /// Remote API method execution using HTTP "get" method. 
    /// </summary>
    private DataType ExecuteGetHttpRequest<ContractType, DataType>(ViddlerMethodAttribute methodAttribute, StringDictionary parameters)
    {
      StringBuilder requestPath = new StringBuilder();
      requestPath.Append((this.EnableSsl && methodAttribute.IsSecure) ? this.SecureBaseUrl : this.BaseUrl);
      requestPath.Append(methodAttribute.MethodName);
      requestPath.Append(".xml");
      requestPath.Append("?key=");
      requestPath.Append(this.ApiKey);
      if (methodAttribute.IsSessionRequired)
      {
        requestPath.Append("&sessionid=");
        requestPath.Append(this.SessionId);
      }

      if (parameters != null && parameters.Keys.Count > 0)
      {
        foreach (string key in parameters.Keys)
        {
          requestPath.Append("&");
          requestPath.Append(key);
          requestPath.Append("=");
          requestPath.Append(ViddlerHelper.EncodeRequestData(parameters[key]));
        }
      }

      try
      {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestPath.ToString());
        request.Method = "GET";
        request.ContentType = "application/x-www-form-urlencoded";
        request.UserAgent = string.Concat("Microsoft .NET, ", this.GetType().Assembly.FullName);
        request.AllowWriteStreamBuffering = true;
        request.Accept = "text/xml";
        request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
        request.KeepAlive = true;
        request.Timeout = int.MaxValue;
        request.ReadWriteTimeout = int.MaxValue;

        DataType responseObject = ViddlerService.HandleHttpResponse<ContractType, DataType>(request, methodAttribute);
        return responseObject;
      }
      catch (System.Net.WebException exception)
      {
        throw ViddlerService.HandleHttpError(exception);
      }
    }

    /// <summary>
    /// Handles a web response from the remote server. 
    /// </summary>
    private static DataType HandleHttpResponse<ContractType, DataType>(HttpWebRequest request, ViddlerMethodAttribute methodAttribute)
    {
      DataType responseObject = default(DataType);
      using (WebResponse response = request.GetResponse())
      {
        using (Stream responseStream = response.GetResponseStream())
        {
          using (MemoryStream stream = new MemoryStream())
          {
            int count;
            byte[] buffer = new byte[1024];
            do
            {
              count = responseStream.Read(buffer, 0, 1024);
              stream.Write(buffer, 0, count);
            } while (count > 0); // copy response stream to "seek-enabled" stream

            stream.Position = 0;
            string messageType = string.Empty;
            XmlReaderSettings readerSettings = new XmlReaderSettings();
            readerSettings.CloseInput = false;
            readerSettings.IgnoreComments = true;
            readerSettings.IgnoreProcessingInstructions = true;
            using (XmlReader reader = XmlReader.Create(stream, readerSettings))
            {
              if (reader.MoveToContent() == XmlNodeType.Element)
              {
                messageType = reader.LocalName;
              }
            }

            stream.Position = 0;
            if (messageType.Equals(methodAttribute.ElementName, StringComparison.Ordinal))
            {
              try
              {
                XmlSerializer serializer = new XmlSerializer(typeof(ContractType));
                responseObject = (DataType)serializer.Deserialize(stream);
              }
              catch (Exception exception)
              {
                if (exception.InnerException != null && exception.InnerException.GetType() == typeof(System.FormatException)) // XmlSerializer has problems with parsing primitive types - removing empty nodes, which are deserialized to properties of primitive type
                {
                  stream.Position = 0;
                  Dictionary<string, Type> nodesToCheck = ViddlerHelper.GetExpectedPrimitiveTypeNodes(typeof(ContractType));
                  XmlDocument responseXml = new XmlDocument();
                  responseXml.PreserveWhitespace = true;
                  responseXml.Load(stream);

                  foreach (string node in nodesToCheck.Keys)
                  {
                    foreach (XmlNode xmlNode in responseXml.SelectNodes(node))
                    {
                      if (string.IsNullOrEmpty(xmlNode.InnerText.Trim()))
                      {
                        xmlNode.ParentNode.RemoveChild(xmlNode);
                      }
                    }
                  }

                  using (MemoryStream xmlStream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(responseXml.OuterXml)))
                  {
                    XmlSerializer serializer = new XmlSerializer(typeof(ContractType));
                    responseObject = (DataType)serializer.Deserialize(xmlStream);
                  }
                }
                else
                {
                  throw;
                }
              }
            }
            else if (messageType.Equals("error", StringComparison.Ordinal))
            {
              XmlSerializer serializer = new XmlSerializer(typeof(ViddlerResponseError));
              ViddlerResponseError errorObject = (ViddlerResponseError)serializer.Deserialize(stream);
              throw new ViddlerRequestException(errorObject, null);
            }
            else
            {
              XmlDocument responseXml = new XmlDocument();
              responseXml.PreserveWhitespace = true;
              responseXml.Load(stream);
              throw new System.InvalidOperationException(responseXml.OuterXml);
            }
          }
        }
      }

      return responseObject;
    }

    /// <summary>
    /// Handles errors occuring during communication with the remote server. 
    /// </summary>
    private static Exception HandleHttpError(System.Net.WebException exception)
    {
      if (exception.Status == WebExceptionStatus.ProtocolError)
      {
        try
        {
          ViddlerResponseError responseObject;
          using (Stream responseStream = exception.Response.GetResponseStream())
          {
            XmlSerializer serializer = new XmlSerializer(typeof(ViddlerResponseError));
            responseObject = (ViddlerResponseError)serializer.Deserialize(responseStream);
          }
          return new ViddlerRequestException(responseObject, exception);
        }
        catch
        {
          return exception;
        }
      }
      return exception;
    }

    #endregion
  }
}
