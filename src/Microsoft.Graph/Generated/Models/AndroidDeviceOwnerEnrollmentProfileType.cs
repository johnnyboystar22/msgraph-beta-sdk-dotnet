using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Android Device Owner Enrollment Profile types.</summary>
    public enum AndroidDeviceOwnerEnrollmentProfileType {
        /// <summary>Not configured; this value is ignored.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Dedicated device.</summary>
        [EnumMember(Value = "dedicatedDevice")]
        DedicatedDevice,
        /// <summary>Fully managed.</summary>
        [EnumMember(Value = "fullyManaged")]
        FullyManaged,
    }
}
