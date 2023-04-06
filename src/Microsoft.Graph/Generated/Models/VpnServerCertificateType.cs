using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The type of certificate the VPN server will present to the VPN client for authentication</summary>
    public enum VpnServerCertificateType {
        /// <summary>RSA</summary>
        [EnumMember(Value = "rsa")]
        Rsa,
        /// <summary>ECDSA256</summary>
        [EnumMember(Value = "ecdsa256")]
        Ecdsa256,
        /// <summary>ECDSA384</summary>
        [EnumMember(Value = "ecdsa384")]
        Ecdsa384,
        /// <summary>ECDSA521</summary>
        [EnumMember(Value = "ecdsa521")]
        Ecdsa521,
    }
}
