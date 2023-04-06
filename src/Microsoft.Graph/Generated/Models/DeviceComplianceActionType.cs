using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Scheduled Action Type Enum</summary>
    public enum DeviceComplianceActionType {
        /// <summary>No Action</summary>
        [EnumMember(Value = "noAction")]
        NoAction,
        /// <summary>Send Notification</summary>
        [EnumMember(Value = "notification")]
        Notification,
        /// <summary>Block the device in AAD</summary>
        [EnumMember(Value = "block")]
        Block,
        /// <summary>Retire the device</summary>
        [EnumMember(Value = "retire")]
        Retire,
        /// <summary>Wipe the device</summary>
        [EnumMember(Value = "wipe")]
        Wipe,
        /// <summary>Remove Resource Access Profiles from the device</summary>
        [EnumMember(Value = "removeResourceAccessProfiles")]
        RemoveResourceAccessProfiles,
        /// <summary>Send push notification to device</summary>
        [EnumMember(Value = "pushNotification")]
        PushNotification,
        /// <summary>Remotely lock the device</summary>
        [EnumMember(Value = "remoteLock")]
        RemoteLock,
    }
}
