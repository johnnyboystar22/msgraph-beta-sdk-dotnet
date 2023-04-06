using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>VPN On-Demand Rule Connection Action.</summary>
    public enum VpnOnDemandRuleConnectionAction {
        /// <summary>Connect.</summary>
        [EnumMember(Value = "connect")]
        Connect,
        /// <summary>Evaluate Connection.</summary>
        [EnumMember(Value = "evaluateConnection")]
        EvaluateConnection,
        /// <summary>Ignore.</summary>
        [EnumMember(Value = "ignore")]
        Ignore,
        /// <summary>Disconnect.</summary>
        [EnumMember(Value = "disconnect")]
        Disconnect,
    }
}
