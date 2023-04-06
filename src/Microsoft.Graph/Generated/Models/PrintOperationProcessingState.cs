using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum PrintOperationProcessingState {
        [EnumMember(Value = "notStarted")]
        NotStarted,
        [EnumMember(Value = "running")]
        Running,
        [EnumMember(Value = "succeeded")]
        Succeeded,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
