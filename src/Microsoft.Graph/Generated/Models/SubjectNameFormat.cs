// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Subject Name Format Options.</summary>
    public enum SubjectNameFormat
    {
        /// <summary>Common name.</summary>
        [EnumMember(Value = "commonName")]
        CommonName,
        /// <summary>Common Name Including Email.</summary>
        [EnumMember(Value = "commonNameIncludingEmail")]
        CommonNameIncludingEmail,
        /// <summary>Common Name As Email.</summary>
        [EnumMember(Value = "commonNameAsEmail")]
        CommonNameAsEmail,
        /// <summary>Custom subject name format.</summary>
        [EnumMember(Value = "custom")]
        Custom,
        /// <summary>Common Name As IMEI.</summary>
        [EnumMember(Value = "commonNameAsIMEI")]
        CommonNameAsIMEI,
        /// <summary>Common Name As Serial Number.</summary>
        [EnumMember(Value = "commonNameAsSerialNumber")]
        CommonNameAsSerialNumber,
        /// <summary>Common Name As Serial Number.</summary>
        [EnumMember(Value = "commonNameAsAadDeviceId")]
        CommonNameAsAadDeviceId,
        /// <summary>Common Name As Serial Number.</summary>
        [EnumMember(Value = "commonNameAsIntuneDeviceId")]
        CommonNameAsIntuneDeviceId,
        /// <summary>Common Name As Serial Number.</summary>
        [EnumMember(Value = "commonNameAsDurableDeviceId")]
        CommonNameAsDurableDeviceId,
    }
}
