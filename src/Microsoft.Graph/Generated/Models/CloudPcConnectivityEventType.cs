using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CloudPcConnectivityEventType {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "userConnection")]
        UserConnection,
        [EnumMember(Value = "userTroubleshooting")]
        UserTroubleshooting,
        [EnumMember(Value = "deviceHealthCheck")]
        DeviceHealthCheck,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
