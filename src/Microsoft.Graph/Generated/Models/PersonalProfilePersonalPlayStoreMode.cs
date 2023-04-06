using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Used together with personalApplications to control how apps in the personal profile are allowed or blocked.</summary>
    public enum PersonalProfilePersonalPlayStoreMode {
        /// <summary>Not configured.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Blocked Apps.</summary>
        [EnumMember(Value = "blockedApps")]
        BlockedApps,
        /// <summary>Allowed Apps.</summary>
        [EnumMember(Value = "allowedApps")]
        AllowedApps,
    }
}
