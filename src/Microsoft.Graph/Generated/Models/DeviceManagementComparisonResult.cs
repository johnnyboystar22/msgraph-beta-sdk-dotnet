using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Setting comparison result type</summary>
    public enum DeviceManagementComparisonResult {
        /// <summary>Unknown setting comparison</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>The setting values are equal</summary>
        [EnumMember(Value = "equal")]
        Equal,
        /// <summary>The setting values are not equal</summary>
        [EnumMember(Value = "notEqual")]
        NotEqual,
        /// <summary>The setting is added</summary>
        [EnumMember(Value = "added")]
        Added,
        /// <summary>The setting is removed</summary>
        [EnumMember(Value = "removed")]
        Removed,
    }
}
