using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>type tracking the encryption state of a secret setting value</summary>
    public enum DeviceManagementConfigurationSecretSettingValueState {
        /// <summary>default invalid value</summary>
        [EnumMember(Value = "invalid")]
        Invalid,
        /// <summary>secret value is not encrypted</summary>
        [EnumMember(Value = "notEncrypted")]
        NotEncrypted,
        /// <summary>a token for the encrypted value is returned by the service</summary>
        [EnumMember(Value = "encryptedValueToken")]
        EncryptedValueToken,
    }
}
