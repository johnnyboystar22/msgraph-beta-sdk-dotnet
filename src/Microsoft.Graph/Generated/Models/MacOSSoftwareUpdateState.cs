using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>MacOS Software Update State</summary>
    public enum MacOSSoftwareUpdateState {
        /// <summary>The software update successfully installed</summary>
        [EnumMember(Value = "success")]
        Success,
        /// <summary>The software update is being downloaded</summary>
        [EnumMember(Value = "downloading")]
        Downloading,
        /// <summary>The software update has been downloaded</summary>
        [EnumMember(Value = "downloaded")]
        Downloaded,
        /// <summary>The software update is being installed</summary>
        [EnumMember(Value = "installing")]
        Installing,
        /// <summary>No action is being taken on this software update</summary>
        [EnumMember(Value = "idle")]
        Idle,
        /// <summary>The software update is available on the device</summary>
        [EnumMember(Value = "available")]
        Available,
        /// <summary>The software update has been scheduled on the device</summary>
        [EnumMember(Value = "scheduled")]
        Scheduled,
        /// <summary>The software update download has failed</summary>
        [EnumMember(Value = "downloadFailed")]
        DownloadFailed,
        /// <summary>There is not enough space to download the update</summary>
        [EnumMember(Value = "downloadInsufficientSpace")]
        DownloadInsufficientSpace,
        /// <summary>There is not enough power to download the update</summary>
        [EnumMember(Value = "downloadInsufficientPower")]
        DownloadInsufficientPower,
        /// <summary>There is insufficient network capacity to download the update</summary>
        [EnumMember(Value = "downloadInsufficientNetwork")]
        DownloadInsufficientNetwork,
        /// <summary>There is not enough space to install the update</summary>
        [EnumMember(Value = "installInsufficientSpace")]
        InstallInsufficientSpace,
        /// <summary>There is not enough power to install the update</summary>
        [EnumMember(Value = "installInsufficientPower")]
        InstallInsufficientPower,
        /// <summary>Installation has failed for an unspecified reason</summary>
        [EnumMember(Value = "installFailed")]
        InstallFailed,
        /// <summary>The schedule update command has failed for an unspecified reason</summary>
        [EnumMember(Value = "commandFailed")]
        CommandFailed,
    }
}
