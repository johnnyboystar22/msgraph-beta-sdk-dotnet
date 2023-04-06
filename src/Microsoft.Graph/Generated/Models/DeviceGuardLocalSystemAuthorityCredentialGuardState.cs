using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum DeviceGuardLocalSystemAuthorityCredentialGuardState {
        /// <summary>Running</summary>
        [EnumMember(Value = "running")]
        Running,
        /// <summary>Reboot required</summary>
        [EnumMember(Value = "rebootRequired")]
        RebootRequired,
        /// <summary>Not licensed for Credential Guard</summary>
        [EnumMember(Value = "notLicensed")]
        NotLicensed,
        /// <summary>Not configured</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Virtualization Based security is not running</summary>
        [EnumMember(Value = "virtualizationBasedSecurityNotRunning")]
        VirtualizationBasedSecurityNotRunning,
    }
}
