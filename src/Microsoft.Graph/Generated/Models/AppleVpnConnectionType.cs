using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Apple VPN connection type.</summary>
    public enum AppleVpnConnectionType {
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
        /// <summary>Custom VPN.</summary>
        [EnumMember(Value = "customVpn")]
        CustomVpn,
        /// <summary>Cisco (IPSec).</summary>
        [EnumMember(Value = "ciscoIPSec")]
        CiscoIPSec,
        /// <summary>Citrix.</summary>
        [EnumMember(Value = "citrix")]
        Citrix,
        /// <summary>Cisco AnyConnect V2.</summary>
        [EnumMember(Value = "ciscoAnyConnectV2")]
        CiscoAnyConnectV2,
        /// <summary>Palo Alto Networks GlobalProtect.</summary>
        [EnumMember(Value = "paloAltoGlobalProtect")]
        PaloAltoGlobalProtect,
        /// <summary>Zscaler Private Access.</summary>
        [EnumMember(Value = "zscalerPrivateAccess")]
        ZscalerPrivateAccess,
        /// <summary>F5 Access 2018.</summary>
        [EnumMember(Value = "f5Access2018")]
        F5Access2018,
        /// <summary>Citrix Sso.</summary>
        [EnumMember(Value = "citrixSso")]
        CitrixSso,
        /// <summary>Palo Alto Networks GlobalProtect V2.</summary>
        [EnumMember(Value = "paloAltoGlobalProtectV2")]
        PaloAltoGlobalProtectV2,
        /// <summary>IKEv2.</summary>
        [EnumMember(Value = "ikEv2")]
        IkEv2,
        /// <summary>AlwaysOn.</summary>
        [EnumMember(Value = "alwaysOn")]
        AlwaysOn,
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
