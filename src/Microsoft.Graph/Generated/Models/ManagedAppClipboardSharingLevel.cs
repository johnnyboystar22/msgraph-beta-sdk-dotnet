using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Represents the level to which the device&apos;s clipboard may be shared between apps</summary>
    public enum ManagedAppClipboardSharingLevel {
        /// <summary>Sharing is allowed between all apps, managed or not</summary>
        [EnumMember(Value = "allApps")]
        AllApps,
        /// <summary>Sharing is allowed between all managed apps with paste in enabled</summary>
        [EnumMember(Value = "managedAppsWithPasteIn")]
        ManagedAppsWithPasteIn,
        /// <summary>Sharing is allowed between all managed apps</summary>
        [EnumMember(Value = "managedApps")]
        ManagedApps,
        /// <summary>Sharing between apps is disabled</summary>
        [EnumMember(Value = "blocked")]
        Blocked,
    }
}
