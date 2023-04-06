using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Values for the InkWorkspaceAccess setting.</summary>
    public enum InkAccessSetting {
        /// <summary>Not configured.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Enabled.</summary>
        [EnumMember(Value = "enabled")]
        Enabled,
        /// <summary>Disabled.</summary>
        [EnumMember(Value = "disabled")]
        Disabled,
    }
}
