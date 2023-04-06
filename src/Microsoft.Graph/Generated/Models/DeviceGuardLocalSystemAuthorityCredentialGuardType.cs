using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Possible values of Credential Guard settings.</summary>
    public enum DeviceGuardLocalSystemAuthorityCredentialGuardType {
        /// <summary>Turns off Credential Guard remotely if configured previously without UEFI Lock.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Turns on Credential Guard with UEFI lock.</summary>
        [EnumMember(Value = "enableWithUEFILock")]
        EnableWithUEFILock,
        /// <summary>Turns on Credential Guard without UEFI lock.</summary>
        [EnumMember(Value = "enableWithoutUEFILock")]
        EnableWithoutUEFILock,
        /// <summary>Disables Credential Guard. This is the default OS value.</summary>
        [EnumMember(Value = "disable")]
        Disable,
    }
}
