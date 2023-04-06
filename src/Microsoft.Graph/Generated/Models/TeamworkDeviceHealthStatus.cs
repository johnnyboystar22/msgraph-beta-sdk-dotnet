using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum TeamworkDeviceHealthStatus {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "offline")]
        Offline,
        [EnumMember(Value = "critical")]
        Critical,
        [EnumMember(Value = "nonUrgent")]
        NonUrgent,
        [EnumMember(Value = "healthy")]
        Healthy,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
