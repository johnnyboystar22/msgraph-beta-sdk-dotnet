using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum HostReputationRuleSeverity {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "medium")]
        Medium,
        [EnumMember(Value = "high")]
        High,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
