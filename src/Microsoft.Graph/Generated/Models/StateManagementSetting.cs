using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>State Management Setting.</summary>
    public enum StateManagementSetting {
        /// <summary>Not configured.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Blocked.</summary>
        [EnumMember(Value = "blocked")]
        Blocked,
        /// <summary>Allowed.</summary>
        [EnumMember(Value = "allowed")]
        Allowed,
    }
}
