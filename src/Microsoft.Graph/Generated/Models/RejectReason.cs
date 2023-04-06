using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum RejectReason {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "busy")]
        Busy,
        [EnumMember(Value = "forbidden")]
        Forbidden,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
