using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Device app management task priority.</summary>
    public enum DeviceAppManagementTaskPriority {
        /// <summary>No priority set.</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>High priority.</summary>
        [EnumMember(Value = "high")]
        High,
        /// <summary>Low priority.</summary>
        [EnumMember(Value = "low")]
        Low,
    }
}
