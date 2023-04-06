using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CloudPcDeviceImageStatus {
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "ready")]
        Ready,
        [EnumMember(Value = "failed")]
        Failed,
    }
}
