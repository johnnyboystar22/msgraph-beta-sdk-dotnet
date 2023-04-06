using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Possible values for defenderSecurityCenterNotificationsFromApp</summary>
    public enum DefenderSecurityCenterNotificationsFromAppType {
        /// <summary>Not Configured</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Block non-critical notifications</summary>
        [EnumMember(Value = "blockNoncriticalNotifications")]
        BlockNoncriticalNotifications,
        /// <summary>Block all notifications</summary>
        [EnumMember(Value = "blockAllNotifications")]
        BlockAllNotifications,
    }
}
