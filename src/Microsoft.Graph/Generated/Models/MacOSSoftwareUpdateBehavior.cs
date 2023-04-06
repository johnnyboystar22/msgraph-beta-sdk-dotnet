using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Update behavior options for macOS software updates.</summary>
    public enum MacOSSoftwareUpdateBehavior {
        /// <summary>Not configured.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Download and/or install the software update, depending on the current device state.</summary>
        [EnumMember(Value = "default")]
        Default,
        /// <summary>Download the software update without installing it.</summary>
        [EnumMember(Value = "downloadOnly")]
        DownloadOnly,
        /// <summary>Install an already downloaded software update.</summary>
        [EnumMember(Value = "installASAP")]
        InstallASAP,
        /// <summary>Download the software update and notify the user via the App Store.</summary>
        [EnumMember(Value = "notifyOnly")]
        NotifyOnly,
        /// <summary>Download the software update and install it at a later time.</summary>
        [EnumMember(Value = "installLater")]
        InstallLater,
    }
}
