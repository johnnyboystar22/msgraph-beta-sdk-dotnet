using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Encryption state</summary>
    public enum EncryptionState {
        /// <summary>Not encrypted</summary>
        [EnumMember(Value = "notEncrypted")]
        NotEncrypted,
        /// <summary>Encrypted</summary>
        [EnumMember(Value = "encrypted")]
        Encrypted,
    }
}
