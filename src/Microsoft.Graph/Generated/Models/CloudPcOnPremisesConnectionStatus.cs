using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CloudPcOnPremisesConnectionStatus {
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "running")]
        Running,
        [EnumMember(Value = "passed")]
        Passed,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "warning")]
        Warning,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
