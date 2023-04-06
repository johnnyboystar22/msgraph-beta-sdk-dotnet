using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum WindowsAutopilotProfileAssignmentDetailedStatus {
        /// <summary>No assignment detailed status</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Hardware requirements are not met. This can happen if a self-deploying AutoPilot Profile is assigned to a device without TPM 2.0.</summary>
        [EnumMember(Value = "hardwareRequirementsNotMet")]
        HardwareRequirementsNotMet,
        /// <summary>Indicates that a Surface Hub AutoPilot Profile is assigned to a device that is not Surface Hub(Aruba).</summary>
        [EnumMember(Value = "surfaceHubProfileNotSupported")]
        SurfaceHubProfileNotSupported,
        /// <summary>Indicates that a HoloLens AutoPilot Profile is assigned to a device that is not HoloLens.</summary>
        [EnumMember(Value = "holoLensProfileNotSupported")]
        HoloLensProfileNotSupported,
        /// <summary>Indicates that a Windows PC AutoPilot Profile is assigned to a device that is not Windows PC.</summary>
        [EnumMember(Value = "windowsPcProfileNotSupported")]
        WindowsPcProfileNotSupported,
        /// <summary>Indicates that a surface Hub 2S  AutoPilot Profile is assigned to a device that is not surface Hub 2S.</summary>
        [EnumMember(Value = "surfaceHub2SProfileNotSupported")]
        SurfaceHub2SProfileNotSupported,
        /// <summary>Placeholder for evolvable enum, but this enum is never returned to the caller, so it shouldn&apos;t be necessary.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
