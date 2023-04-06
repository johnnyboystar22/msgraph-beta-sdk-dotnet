using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The type of VPN local identifier</summary>
    public enum VpnLocalIdentifier {
        /// <summary>Device Fully Qualified Domain Name</summary>
        [EnumMember(Value = "deviceFQDN")]
        DeviceFQDN,
        /// <summary>Empty</summary>
        [EnumMember(Value = "empty")]
        Empty,
        /// <summary>Client Certificate Subject Name</summary>
        [EnumMember(Value = "clientCertificateSubjectName")]
        ClientCertificateSubjectName,
    }
}
