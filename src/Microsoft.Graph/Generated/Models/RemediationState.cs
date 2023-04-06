using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Indicates the type of execution status of the device management script.</summary>
    public enum RemediationState {
        /// <summary>Unknown result.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Remediation script execution was skipped</summary>
        [EnumMember(Value = "skipped")]
        Skipped,
        /// <summary>Remediation script executed successfully and remediated the device state</summary>
        [EnumMember(Value = "success")]
        Success,
        /// <summary>Remediation script executed successfully but failed to remediated the device state</summary>
        [EnumMember(Value = "remediationFailed")]
        RemediationFailed,
        /// <summary>Remediation script execution encountered and error or timed out</summary>
        [EnumMember(Value = "scriptError")]
        ScriptError,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
