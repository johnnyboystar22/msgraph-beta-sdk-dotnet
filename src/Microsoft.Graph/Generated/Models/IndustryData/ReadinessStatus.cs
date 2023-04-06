using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.IndustryData {
    public enum ReadinessStatus {
        [EnumMember(Value = "notReady")]
        NotReady,
        [EnumMember(Value = "ready")]
        Ready,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "disabled")]
        Disabled,
        [EnumMember(Value = "expired")]
        Expired,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
