using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The possible options to configure S mode unlock</summary>
    public enum WindowsSModeConfiguration {
        /// <summary>This option will remove all restrictions to unlock S mode - default</summary>
        [EnumMember(Value = "noRestriction")]
        NoRestriction,
        /// <summary>This option will block the user to unlock the device from S mode</summary>
        [EnumMember(Value = "block")]
        Block,
        /// <summary>This option will unlock the device from S mode</summary>
        [EnumMember(Value = "unlock")]
        Unlock,
    }
}
