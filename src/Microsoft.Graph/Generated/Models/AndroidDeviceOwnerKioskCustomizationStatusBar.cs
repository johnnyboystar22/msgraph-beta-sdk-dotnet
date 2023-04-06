using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>An enum representing possible values for kiosk customization system navigation.</summary>
    public enum AndroidDeviceOwnerKioskCustomizationStatusBar {
        /// <summary>Not configured; this value defaults to STATUS_BAR_UNSPECIFIED.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>System info and notifications are shown on the status bar in kiosk mode.</summary>
        [EnumMember(Value = "notificationsAndSystemInfoEnabled")]
        NotificationsAndSystemInfoEnabled,
        /// <summary>Only system info is shown on the status bar in kiosk mode.</summary>
        [EnumMember(Value = "systemInfoOnly")]
        SystemInfoOnly,
    }
}
