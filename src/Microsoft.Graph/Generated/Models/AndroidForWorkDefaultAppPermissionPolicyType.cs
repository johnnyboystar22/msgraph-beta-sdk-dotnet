using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Android For Work default app permission policy type.</summary>
    public enum AndroidForWorkDefaultAppPermissionPolicyType {
        /// <summary>Device default value, no intent.</summary>
        [EnumMember(Value = "deviceDefault")]
        DeviceDefault,
        /// <summary>Prompt.</summary>
        [EnumMember(Value = "prompt")]
        Prompt,
        /// <summary>Auto grant.</summary>
        [EnumMember(Value = "autoGrant")]
        AutoGrant,
        /// <summary>Auto deny.</summary>
        [EnumMember(Value = "autoDeny")]
        AutoDeny,
    }
}
