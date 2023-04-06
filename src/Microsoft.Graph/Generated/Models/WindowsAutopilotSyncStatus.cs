using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum WindowsAutopilotSyncStatus {
        /// <summary>Unknown sync status</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Sync is in progress</summary>
        [EnumMember(Value = "inProgress")]
        InProgress,
        /// <summary>Sync completed.</summary>
        [EnumMember(Value = "completed")]
        Completed,
        /// <summary>Sync failed.</summary>
        [EnumMember(Value = "failed")]
        Failed,
    }
}
