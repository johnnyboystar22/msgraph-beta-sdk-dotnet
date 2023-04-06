using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>VPN connection types.</summary>
    public enum Windows10VpnConnectionType {
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
        /// <summary>Automatic.</summary>
        [EnumMember(Value = "automatic")]
        Automatic,
        /// <summary>IKEv2.</summary>
        [EnumMember(Value = "ikEv2")]
        IkEv2,
        /// <summary>L2TP.</summary>
        [EnumMember(Value = "l2tp")]
        L2tp,
        /// <summary>PPTP.</summary>
        [EnumMember(Value = "pptp")]
        Pptp,
        /// <summary>Citrix.</summary>
        [EnumMember(Value = "citrix")]
        Citrix,
        /// <summary>Palo Alto Networks GlobalProtect.</summary>
        [EnumMember(Value = "paloAltoGlobalProtect")]
        PaloAltoGlobalProtect,
        /// <summary>Cisco AnyConnect</summary>
        [EnumMember(Value = "ciscoAnyConnect")]
        CiscoAnyConnect,
        /// <summary>Sentinel member for cases where the client cannot handle the new enum values.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        /// <summary>Microsoft Tunnel connection type</summary>
        [EnumMember(Value = "microsoftTunnel")]
        MicrosoftTunnel,
    }
}
