using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Device remediation status, indicating whether or not hardware has been changed for an Autopilot-registered device.</summary>
    public enum WindowsAutopilotDeviceRemediationState {
        /// <summary>Unknown status.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>No hardware change has been detected.</summary>
        [EnumMember(Value = "noRemediationRequired")]
        NoRemediationRequired,
        /// <summary>Hardware change detected on client. Additional remediation is required.</summary>
        [EnumMember(Value = "automaticRemediationRequired")]
        AutomaticRemediationRequired,
        /// <summary>Hardware change detected on client that could not resolved automatically. Additional remediation is required.</summary>
        [EnumMember(Value = "manualRemediationRequired")]
        ManualRemediationRequired,
        /// <summary>Marks the end of known enum values, and allows for additional values in the future.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
