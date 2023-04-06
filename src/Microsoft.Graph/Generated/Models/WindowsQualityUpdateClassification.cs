using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Windows quality update classification</summary>
    public enum WindowsQualityUpdateClassification {
        /// <summary>All update type</summary>
        [EnumMember(Value = "all")]
        All,
        /// <summary>Security only update type</summary>
        [EnumMember(Value = "security")]
        Security,
        /// <summary>Non security only update type</summary>
        [EnumMember(Value = "nonSecurity")]
        NonSecurity,
    }
}
