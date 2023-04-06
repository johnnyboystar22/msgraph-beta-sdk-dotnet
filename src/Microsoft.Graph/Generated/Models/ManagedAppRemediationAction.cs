using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>An admin initiated action to be applied on a managed app.</summary>
    public enum ManagedAppRemediationAction {
        /// <summary>app and the corresponding company data to be blocked</summary>
        [EnumMember(Value = "block")]
        Block,
        /// <summary>app and the corresponding company data to be wiped</summary>
        [EnumMember(Value = "wipe")]
        Wipe,
        /// <summary>app and the corresponding user to be warned</summary>
        [EnumMember(Value = "warn")]
        Warn,
    }
}
