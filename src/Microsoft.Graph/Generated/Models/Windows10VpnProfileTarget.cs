using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Windows 10 VPN profile target types.</summary>
    public enum Windows10VpnProfileTarget {
        /// <summary>User targeted VPN profile.</summary>
        [EnumMember(Value = "user")]
        User,
        /// <summary>Device targeted VPN profile.</summary>
        [EnumMember(Value = "device")]
        Device,
        /// <summary>AutoPilot Device targeted VPN profile.</summary>
        [EnumMember(Value = "autoPilotDevice")]
        AutoPilotDevice,
    }
}
