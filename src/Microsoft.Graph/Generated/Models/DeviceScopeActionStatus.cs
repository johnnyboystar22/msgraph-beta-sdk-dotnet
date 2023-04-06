using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Indicates the status of the attempted device scope action</summary>
    public enum DeviceScopeActionStatus {
        /// <summary>Indicates the device scope action failed to trigger.</summary>
        [EnumMember(Value = "failed")]
        Failed,
        /// <summary>Indicates the device scope action was successfully triggered.</summary>
        [EnumMember(Value = "succeeded")]
        Succeeded,
        /// <summary>Placeholder value for future expansion.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
