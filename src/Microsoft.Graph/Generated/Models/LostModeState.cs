using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>State of lost mode, indicating if lost mode is enabled or disabled</summary>
    public enum LostModeState {
        /// <summary>Lost mode is disabled.</summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>Lost mode is enabled.</summary>
        [EnumMember(Value = "enabled")]
        Enabled,
    }
}
