using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Specifies the routing policy for a VPN traffic rule.</summary>
    public enum VpnTrafficRuleRoutingPolicyType {
        /// <summary>No routing policy specified.</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Network traffic for the specified app will be routed through the VPN.</summary>
        [EnumMember(Value = "splitTunnel")]
        SplitTunnel,
        /// <summary>All network traffic will be routed through the VPN.</summary>
        [EnumMember(Value = "forceTunnel")]
        ForceTunnel,
    }
}
