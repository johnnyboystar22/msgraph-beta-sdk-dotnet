using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum MembershipRuleProcessingStatusDetails {
        [EnumMember(Value = "NotStarted")]
        NotStarted,
        [EnumMember(Value = "Running")]
        Running,
        [EnumMember(Value = "Failed")]
        Failed,
        [EnumMember(Value = "Succeeded")]
        Succeeded,
        [EnumMember(Value = "UnsupportedFutureValue")]
        UnsupportedFutureValue,
    }
}
