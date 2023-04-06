using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Enum type that represent the status of log collection</summary>
    public enum MicrosoftTunnelLogCollectionStatus {
        /// <summary>Indicates that the log collection is in progress</summary>
        [EnumMember(Value = "pending")]
        Pending,
        /// <summary>Indicates that the log collection is completed</summary>
        [EnumMember(Value = "completed")]
        Completed,
        /// <summary>Indicates that the log collection has failed</summary>
        [EnumMember(Value = "failed")]
        Failed,
        /// <summary>Placeholder value for future expansion enums</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
