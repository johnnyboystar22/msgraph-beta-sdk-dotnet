using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Device Management Certification Authority Types.</summary>
    public enum DeviceManagementCertificationAuthority {
        /// <summary>Not configured.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Microsoft Certification Authority type.</summary>
        [EnumMember(Value = "microsoft")]
        Microsoft,
        /// <summary>DigiCert Certification Authority type.</summary>
        [EnumMember(Value = "digiCert")]
        DigiCert,
    }
}
