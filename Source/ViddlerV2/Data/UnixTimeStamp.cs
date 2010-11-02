using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using System.Xml;
using System.Globalization;

namespace Viddler.Data
{
  /// <summary>
  /// Represents an UNIX time stamp using Unix Epoch as a base time.
  /// </summary>
  [Serializable]
  public struct UnixTimeStamp : IXmlSerializable, IComparable<double>, IComparable<DateTime>, IEquatable<double>, IEquatable<DateTime>
  {
    /// <summary>
    /// Stores Unix Epoch base value equal to 1970-01-01 00:00:00.
    /// </summary>
    public static readonly DateTime UnixEpoch;

    /// <summary>
    /// Represent a Unix time stamp value.
    /// </summary>
    public double TimeStamp;

    /// <summary>
    /// Initializes a new instance of UnixTimeStamp class.
    /// </summary>
    public UnixTimeStamp(double timeStamp)
    {
      TimeStamp = timeStamp;
    }

    /// <summary/>
    static UnixTimeStamp()
    {
      UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Unspecified);
    }

    /// <summary>
    /// Represent an Unix time stamp value using DateTime structure.
    /// </summary>
    public DateTime DateTime
    {
      get
      {
        return UnixTimeStamp.UnixEpoch.AddSeconds(TimeStamp);
      }
      set
      {
        TimeStamp = (value - UnixTimeStamp.UnixEpoch).TotalSeconds;
      }
    }

    /// <summary>
    /// Implementation of IXmlSerializable method used for serialization/deserialization.
    /// </summary>
    public System.Xml.Schema.XmlSchema GetSchema()
    {
      return null;
    }

    /// <summary>
    /// Implementation of IXmlSerializable method used for deserialization.
    /// </summary>
    public void ReadXml(XmlReader reader)
    {
      this.TimeStamp = double.Parse(reader.ReadElementString(), NumberStyles.Any, CultureInfo.InvariantCulture);
    }

    /// <summary>
    /// Implementation of IXmlSerializable method used for serialization.
    /// </summary>
    public void WriteXml(XmlWriter writer)
    {
      writer.WriteString(this.TimeStamp.ToString(CultureInfo.InvariantCulture));
    }

    /// <summary>
    /// Compares this instance to a specified object and returns an indication of their relative values.
    /// </summary>
    public int CompareTo(double other)
    {
      return this.TimeStamp.CompareTo(other);
    }

    /// <summary>
    /// Compares this instance to a specified object and returns an indication of their relative values.
    /// </summary>
    public int CompareTo(DateTime other)
    {
      return this.DateTime.CompareTo(other);
    }

    /// <summary>
    /// Returns a value indicating whether this instance is equal to a specified DateTime value.
    /// </summary>
    public bool Equals(DateTime other)
    {
      return this.DateTime.Equals(other);
    }

    /// <summary>
    /// Returns a value indicating whether this instance is equal to a specified double value.
    /// </summary>
    public bool Equals(double other)
    {
      return this.TimeStamp.Equals(other);
    }

    /// <summary>
    /// Converts the time stamp value of this instance to its equivalent string representation.
    /// </summary>
    public override string ToString()
    {
      return this.TimeStamp.ToString(CultureInfo.InvariantCulture);
    }
  }
}
