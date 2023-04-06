using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Restrict managed app notification</summary>
    public enum ManagedAppNotificationRestriction {
        /// <summary>Share all notifications.</summary>
        [EnumMember(Value = "allow")]
        Allow,
        /// <summary>Do not share Orgnizational data in notifications.</summary>
        [EnumMember(Value = "blockOrganizationalData")]
        BlockOrganizationalData,
        /// <summary>Do not share notifications.</summary>
        [EnumMember(Value = "block")]
        Block,
    }
}
