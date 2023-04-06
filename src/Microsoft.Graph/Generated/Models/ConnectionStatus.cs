using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ConnectionStatus {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "attempted")]
        Attempted,
        [EnumMember(Value = "succeeded")]
        Succeeded,
        [EnumMember(Value = "blocked")]
        Blocked,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
