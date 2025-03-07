// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public enum ImportedDeviceIdentityType
    #pragma warning restore CS1591
    {
        /// <summary>Unknown value of importedDeviceIdentityType.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Device Identity is of type imei.</summary>
        [EnumMember(Value = "imei")]
        Imei,
        /// <summary>Device Identity is of type serial number.</summary>
        [EnumMember(Value = "serialNumber")]
        SerialNumber,
        /// <summary>Device Identity is of type manufacturer + model + serial number semi-colon delimited tuple with enforced order.</summary>
        [EnumMember(Value = "manufacturerModelSerial")]
        ManufacturerModelSerial,
    }
}
