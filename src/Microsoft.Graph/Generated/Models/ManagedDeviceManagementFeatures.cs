using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Device management features.</summary>
    public enum ManagedDeviceManagementFeatures {
        /// <summary>Unknown device management features.</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Microsoft Managed Desktop</summary>
        [EnumMember(Value = "microsoftManagedDesktop")]
        MicrosoftManagedDesktop,
    }
}
