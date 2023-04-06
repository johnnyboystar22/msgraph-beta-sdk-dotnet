using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum HostReputationClassification {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "neutral")]
        Neutral,
        [EnumMember(Value = "suspicious")]
        Suspicious,
        [EnumMember(Value = "malicious")]
        Malicious,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
