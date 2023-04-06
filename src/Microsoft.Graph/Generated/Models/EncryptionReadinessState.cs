using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Encryption readiness state</summary>
    public enum EncryptionReadinessState {
        /// <summary>Not ready</summary>
        [EnumMember(Value = "notReady")]
        NotReady,
        /// <summary>Ready</summary>
        [EnumMember(Value = "ready")]
        Ready,
    }
}
