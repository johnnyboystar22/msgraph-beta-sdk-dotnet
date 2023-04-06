using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Specify whether the rule applies to inbound traffic or outbound traffic.</summary>
    public enum VpnTrafficDirection {
        /// <summary>The rule applies to all outbound traffic.</summary>
        [EnumMember(Value = "outbound")]
        Outbound,
        /// <summary>The rule applies to all inbound traffic.</summary>
        [EnumMember(Value = "inbound")]
        Inbound,
        /// <summary>Evolvable enum member</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
