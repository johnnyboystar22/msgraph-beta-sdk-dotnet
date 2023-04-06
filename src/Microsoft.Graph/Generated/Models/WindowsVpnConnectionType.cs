using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Windows VPN connection type.</summary>
    public enum WindowsVpnConnectionType {
        /// <summary>Pulse Secure.</summary>
        [EnumMember(Value = "pulseSecure")]
        PulseSecure,
        /// <summary>F5 Edge Client.</summary>
        [EnumMember(Value = "f5EdgeClient")]
        F5EdgeClient,
        /// <summary>Dell SonicWALL Mobile Connection.</summary>
        [EnumMember(Value = "dellSonicWallMobileConnect")]
        DellSonicWallMobileConnect,
        /// <summary>Check Point Capsule VPN.</summary>
        [EnumMember(Value = "checkPointCapsuleVpn")]
        CheckPointCapsuleVpn,
    }
}
