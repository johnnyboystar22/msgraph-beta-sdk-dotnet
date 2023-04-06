using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum OperationResult {
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "failure")]
        Failure,
        [EnumMember(Value = "timeout")]
        Timeout,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
