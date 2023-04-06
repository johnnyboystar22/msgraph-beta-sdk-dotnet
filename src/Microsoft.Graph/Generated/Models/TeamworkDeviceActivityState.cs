using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum TeamworkDeviceActivityState {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "busy")]
        Busy,
        [EnumMember(Value = "idle")]
        Idle,
        [EnumMember(Value = "unavailable")]
        Unavailable,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
