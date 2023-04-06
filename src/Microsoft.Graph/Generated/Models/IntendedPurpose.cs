using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>PFX Import Options.</summary>
    public enum IntendedPurpose {
        /// <summary>Unassigned</summary>
        [EnumMember(Value = "unassigned")]
        Unassigned,
        /// <summary>SmimeEncryption</summary>
        [EnumMember(Value = "smimeEncryption")]
        SmimeEncryption,
        /// <summary>SmimeSigning</summary>
        [EnumMember(Value = "smimeSigning")]
        SmimeSigning,
        /// <summary>VPN</summary>
        [EnumMember(Value = "vpn")]
        Vpn,
        /// <summary>Wifi</summary>
        [EnumMember(Value = "wifi")]
        Wifi,
    }
}
