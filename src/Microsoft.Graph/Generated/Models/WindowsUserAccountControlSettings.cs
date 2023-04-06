using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Possible values for Windows user account control settings.</summary>
    public enum WindowsUserAccountControlSettings {
        /// <summary>User Defined, default value, no intent.</summary>
        [EnumMember(Value = "userDefined")]
        UserDefined,
        /// <summary>Always notify.</summary>
        [EnumMember(Value = "alwaysNotify")]
        AlwaysNotify,
        /// <summary>Notify on app changes.</summary>
        [EnumMember(Value = "notifyOnAppChanges")]
        NotifyOnAppChanges,
        /// <summary>Notify on app changes without dimming desktop.</summary>
        [EnumMember(Value = "notifyOnAppChangesWithoutDimming")]
        NotifyOnAppChangesWithoutDimming,
        /// <summary>Never notify.</summary>
        [EnumMember(Value = "neverNotify")]
        NeverNotify,
    }
}
