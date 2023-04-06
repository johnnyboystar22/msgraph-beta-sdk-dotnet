using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>VPN On-Demand Rule Connection network interface type.</summary>
    public enum VpnOnDemandRuleInterfaceTypeMatch {
        /// <summary>NotConfigured</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Ethernet.</summary>
        [EnumMember(Value = "ethernet")]
        Ethernet,
        /// <summary>WiFi.</summary>
        [EnumMember(Value = "wiFi")]
        WiFi,
        /// <summary>Cellular.</summary>
        [EnumMember(Value = "cellular")]
        Cellular,
    }
}
