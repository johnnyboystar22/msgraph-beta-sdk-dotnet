using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Security Baseline Compliance State</summary>
    public enum SecurityBaselineComplianceState {
        /// <summary>Unknown state</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Secure state</summary>
        [EnumMember(Value = "secure")]
        Secure,
        /// <summary>Not applicable state</summary>
        [EnumMember(Value = "notApplicable")]
        NotApplicable,
        /// <summary>Not secure state</summary>
        [EnumMember(Value = "notSecure")]
        NotSecure,
        /// <summary>Error state</summary>
        [EnumMember(Value = "error")]
        Error,
        /// <summary>Conflict state</summary>
        [EnumMember(Value = "conflict")]
        Conflict,
    }
}
