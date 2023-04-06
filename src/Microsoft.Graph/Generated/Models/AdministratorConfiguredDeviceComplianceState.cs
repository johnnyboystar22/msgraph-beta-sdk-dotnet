using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Administrator configured device compliance state Enum</summary>
    public enum AdministratorConfiguredDeviceComplianceState {
        /// <summary>Set compliance state based on other compliance polices</summary>
        [EnumMember(Value = "basedOnDeviceCompliancePolicy")]
        BasedOnDeviceCompliancePolicy,
        /// <summary>Set compliance to nonCompliant</summary>
        [EnumMember(Value = "nonCompliant")]
        NonCompliant,
    }
}
