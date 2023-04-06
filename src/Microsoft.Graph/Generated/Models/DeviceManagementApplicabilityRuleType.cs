using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Supported Applicability rule types for Device Configuration</summary>
    public enum DeviceManagementApplicabilityRuleType {
        /// <summary>Include</summary>
        [EnumMember(Value = "include")]
        Include,
        /// <summary>Exclude</summary>
        [EnumMember(Value = "exclude")]
        Exclude,
    }
}
