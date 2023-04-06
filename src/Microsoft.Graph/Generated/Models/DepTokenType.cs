using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum DepTokenType {
        /// <summary>Token Type is None</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Token Type is Dep.</summary>
        [EnumMember(Value = "dep")]
        Dep,
        /// <summary>Token Type is Apple School Manager</summary>
        [EnumMember(Value = "appleSchoolManager")]
        AppleSchoolManager,
    }
}
