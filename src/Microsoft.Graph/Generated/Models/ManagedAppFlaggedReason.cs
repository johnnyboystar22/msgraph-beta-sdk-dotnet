using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The reason for which a user has been flagged</summary>
    public enum ManagedAppFlaggedReason {
        /// <summary>No issue.</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>The app registration is running on a rooted/unlocked device.</summary>
        [EnumMember(Value = "rootedDevice")]
        RootedDevice,
        /// <summary>The app registration is running on an Android device on which the bootloader is unlocked.</summary>
        [EnumMember(Value = "androidBootloaderUnlocked")]
        AndroidBootloaderUnlocked,
        /// <summary>The app registration is running on an Android device on which the factory ROM has been modified.</summary>
        [EnumMember(Value = "androidFactoryRomModified")]
        AndroidFactoryRomModified,
    }
}
