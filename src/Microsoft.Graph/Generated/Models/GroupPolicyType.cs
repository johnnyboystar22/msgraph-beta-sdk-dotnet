using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Type of Group Policy File or Definition.</summary>
    public enum GroupPolicyType {
        /// <summary>Group Policy administrative templates built-in to the Policy configuration service provider (CSP).</summary>
        [EnumMember(Value = "admxBacked")]
        AdmxBacked,
        /// <summary>Group Policy administrative templates installed using the Policy configuration service provider (CSP).</summary>
        [EnumMember(Value = "admxIngested")]
        AdmxIngested,
    }
}
