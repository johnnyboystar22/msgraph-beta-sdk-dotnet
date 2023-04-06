using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Subject Name Format Options for Apple devices.</summary>
    public enum AppleSubjectNameFormat {
        /// <summary>Common name.</summary>
        [EnumMember(Value = "commonName")]
        CommonName,
        /// <summary>Common name as email.</summary>
        [EnumMember(Value = "commonNameAsEmail")]
        CommonNameAsEmail,
        /// <summary>Custom subject name format.</summary>
        [EnumMember(Value = "custom")]
        Custom,
        /// <summary>Common Name Including Email.</summary>
        [EnumMember(Value = "commonNameIncludingEmail")]
        CommonNameIncludingEmail,
        /// <summary>Common Name As IMEI.</summary>
        [EnumMember(Value = "commonNameAsIMEI")]
        CommonNameAsIMEI,
        /// <summary>Common Name As Serial Number.</summary>
        [EnumMember(Value = "commonNameAsSerialNumber")]
        CommonNameAsSerialNumber,
    }
}
