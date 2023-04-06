using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>App source options for iOS kiosk mode.</summary>
    public enum IosKioskModeAppType {
        /// <summary>Device default value, no intent.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>The app to be run comes from the app store.</summary>
        [EnumMember(Value = "appStoreApp")]
        AppStoreApp,
        /// <summary>The app to be run is built into the device.</summary>
        [EnumMember(Value = "managedApp")]
        ManagedApp,
        /// <summary>The app to be run is a managed app.</summary>
        [EnumMember(Value = "builtInApp")]
        BuiltInApp,
    }
}
