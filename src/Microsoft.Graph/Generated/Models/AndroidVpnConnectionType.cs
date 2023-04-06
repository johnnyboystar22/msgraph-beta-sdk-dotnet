using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Android VPN connection type.</summary>
    public enum AndroidVpnConnectionType {
        /// <summary>Cisco AnyConnect.</summary>
        [EnumMember(Value = "ciscoAnyConnect")]
        CiscoAnyConnect,
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
        /// <summary>Citrix</summary>
        [EnumMember(Value = "citrix")]
        Citrix,
        /// <summary>Microsoft Tunnel.</summary>
        [EnumMember(Value = "microsoftTunnel")]
        MicrosoftTunnel,
        /// <summary>NetMotion Mobility.</summary>
        [EnumMember(Value = "netMotionMobility")]
        NetMotionMobility,
        /// <summary>Microsoft Protect.</summary>
        [EnumMember(Value = "microsoftProtect")]
        MicrosoftProtect,
    }
}
