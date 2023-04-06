using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum PolicyStatus {
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "error")]
        Error,
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
