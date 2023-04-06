using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provider type for per-app VPN.</summary>
    public enum VpnProviderType {
        /// <summary>Tunnel traffic is not explicitly configured.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Tunnel traffic at the application layer.</summary>
        [EnumMember(Value = "appProxy")]
        AppProxy,
        /// <summary>Tunnel traffic at the IP layer.</summary>
        [EnumMember(Value = "packetTunnel")]
        PacketTunnel,
    }
}
