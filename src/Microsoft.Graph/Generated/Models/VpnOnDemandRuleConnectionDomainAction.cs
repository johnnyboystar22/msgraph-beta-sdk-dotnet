using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>VPN On-Demand Rule Connection Domain Action.</summary>
    public enum VpnOnDemandRuleConnectionDomainAction {
        /// <summary>Connect if needed.</summary>
        [EnumMember(Value = "connectIfNeeded")]
        ConnectIfNeeded,
        /// <summary>Never connect.</summary>
        [EnumMember(Value = "neverConnect")]
        NeverConnect,
    }
}
