using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum EventPropagationStatus {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "inProcessing")]
        InProcessing,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
