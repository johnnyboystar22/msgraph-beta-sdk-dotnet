using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>An admin enforced Android SafetyNet Device Attestation requirement on a managed app.</summary>
    public enum AndroidManagedAppSafetyNetDeviceAttestationType {
        /// <summary>no requirement set</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>require that Android device passes SafetyNet Basic Integrity validation</summary>
        [EnumMember(Value = "basicIntegrity")]
        BasicIntegrity,
        /// <summary>require that Android device passes SafetyNet Basic Integrity and Device Certification validations</summary>
        [EnumMember(Value = "basicIntegrityAndDeviceCertification")]
        BasicIntegrityAndDeviceCertification,
    }
}
