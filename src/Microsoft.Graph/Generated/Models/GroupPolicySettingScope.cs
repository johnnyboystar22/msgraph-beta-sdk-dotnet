using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Scope of the group policy setting.</summary>
    public enum GroupPolicySettingScope {
        /// <summary>Device scope unknown</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Device scope</summary>
        [EnumMember(Value = "device")]
        Device,
        /// <summary>User scope</summary>
        [EnumMember(Value = "user")]
        User,
    }
}
