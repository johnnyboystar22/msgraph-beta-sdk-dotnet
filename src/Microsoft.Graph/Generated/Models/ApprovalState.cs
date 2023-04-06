using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ApprovalState {
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "approved")]
        Approved,
        [EnumMember(Value = "denied")]
        Denied,
        [EnumMember(Value = "aborted")]
        Aborted,
        [EnumMember(Value = "canceled")]
        Canceled,
    }
}
