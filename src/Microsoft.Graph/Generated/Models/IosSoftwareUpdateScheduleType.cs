using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Update schedule type for iOS software updates.</summary>
    public enum IosSoftwareUpdateScheduleType {
        /// <summary>Update outside of active hours.</summary>
        [EnumMember(Value = "updateOutsideOfActiveHours")]
        UpdateOutsideOfActiveHours,
        /// <summary>Always update.</summary>
        [EnumMember(Value = "alwaysUpdate")]
        AlwaysUpdate,
        /// <summary>Update during time windows.</summary>
        [EnumMember(Value = "updateDuringTimeWindows")]
        UpdateDuringTimeWindows,
        /// <summary>Update outside of time windows.</summary>
        [EnumMember(Value = "updateOutsideOfTimeWindows")]
        UpdateOutsideOfTimeWindows,
    }
}
