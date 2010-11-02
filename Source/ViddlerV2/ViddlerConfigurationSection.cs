using System;
using System.Configuration;

namespace Viddler
{
  /// <summary>
  /// Section handler for Viddler service configuration settings.
  /// </summary>
  /// <example>
  /// Configuration of the section handler in .config file:
  /// <code>
  /// <![CDATA[
  /// <?xml version="1.0"?>
  /// <configuration>
  ///   <configSections>
  /// 	  <section name="viddlerV2" type="Viddler.ViddlerConfigurationSection, ViddlerV2" />
  ///   </configSections>
  ///   <viddlerV2
  ///     apiKey="xxxxxxxxxxxxxxxxxxxx"
  ///     baseUrl="http://api.viddler.com/api/v2/"
  ///     secureBaseUrl="https://api.viddler.com/api/v2/"
  ///     enableSsl="true" />
  /// </configuration>
  /// ]]>
  /// </code>
  /// </example>
  public sealed class ViddlerConfigurationSection : ConfigurationSection
  {
    /// <summary>
    /// Gets or sets a base HTTP URL for the remote Viddler API methods.
    /// </summary>
    [ConfigurationProperty("baseUrl", IsRequired = true)]
    public string BaseUrl
    {
      get
      {
        return base["baseUrl"] as string;
      }
      set
      {
        base["baseUrl"] = value;
      }
    }

    /// <summary>
    /// Gets or sets a base HTTPS URL for the remote Viddler API methods.
    /// </summary>
    [ConfigurationProperty("secureBaseUrl", IsRequired = false)]
    public string SecureBaseUrl
    {
      get
      {
        return base["secureBaseUrl"] as string;
      }
      set
      {
        base["secureBaseUrl"] = value;
      }
    }

    /// <summary>
    /// Gets or sets Viddler API key.
    /// </summary>
    [ConfigurationProperty("apiKey", IsRequired = true)]
    public string ApiKey
    {
      get
      {
        return this["apiKey"] as string;
      }
      set
      {
        this["apiKey"] = value;
      }
    }

    /// <summary>
    /// Gets or sets a value indicating whether to use SecureBaseUrl.
    /// </summary>
    [ConfigurationProperty("enableSsl", IsRequired = false)]
    public bool EnableSsl
    {
      get
      {
        return (bool)this["enableSsl"] && !string.IsNullOrEmpty(this.SecureBaseUrl);
      }
      set
      {
        this["enableSsl"] = value;
      }
    }

    /// <summary>
    /// Gets an instance of the current configuration settings.
    /// </summary>
    public static ViddlerConfigurationSection Instance
    {
      get
      {
        return (ViddlerConfigurationSection)ConfigurationManager.GetSection("viddlerV2");
      }
    }
  }
}
