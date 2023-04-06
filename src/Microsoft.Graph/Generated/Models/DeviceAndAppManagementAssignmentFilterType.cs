using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Represents type of the assignment filter.</summary>
    public enum DeviceAndAppManagementAssignmentFilterType {
        /// <summary>Default value. Do not use.</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Indicates in-filter, rule matching will offer the payload to devices.</summary>
        [EnumMember(Value = "include")]
        Include,
        /// <summary>Indicates out-filter, rule matching will not offer the payload to devices.</summary>
        [EnumMember(Value = "exclude")]
        Exclude,
    }
}
