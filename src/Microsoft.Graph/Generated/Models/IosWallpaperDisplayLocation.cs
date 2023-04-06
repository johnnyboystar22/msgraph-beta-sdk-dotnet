using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>An enum type for wallpaper display location specifier.</summary>
    public enum IosWallpaperDisplayLocation {
        /// <summary>No location specified for wallpaper display.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>A configured wallpaper image is displayed on Lock screen.</summary>
        [EnumMember(Value = "lockScreen")]
        LockScreen,
        /// <summary>A configured wallpaper image is displayed on Home (icon list) screen.</summary>
        [EnumMember(Value = "homeScreen")]
        HomeScreen,
        /// <summary>A configured wallpaper image is displayed on Lock screen and Home screen.</summary>
        [EnumMember(Value = "lockAndHomeScreens")]
        LockAndHomeScreens,
    }
}
