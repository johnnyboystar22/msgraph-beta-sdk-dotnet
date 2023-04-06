using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Android action taken when an app requests a dangerous permission.</summary>
    public enum AndroidPermissionActionType {
        [EnumMember(Value = "prompt")]
        Prompt,
        [EnumMember(Value = "autoGrant")]
        AutoGrant,
        [EnumMember(Value = "autoDeny")]
        AutoDeny,
    }
}
