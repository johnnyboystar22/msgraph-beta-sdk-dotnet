using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>An admin enforced Android SafetyNet evaluation type requirement on a managed app.</summary>
    public enum AndroidManagedAppSafetyNetEvaluationType {
        /// <summary>Require basic evaluation</summary>
        [EnumMember(Value = "basic")]
        Basic,
        /// <summary>Require hardware backed evaluation</summary>
        [EnumMember(Value = "hardwareBacked")]
        HardwareBacked,
    }
}
