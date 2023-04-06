using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Process identifier types for MacOS Privacy Preferences</summary>
    public enum MacOSProcessIdentifierType {
        /// <summary>Indicates an app with a bundle ID.</summary>
        [EnumMember(Value = "bundleID")]
        BundleID,
        /// <summary>Indicates a file path for a process.</summary>
        [EnumMember(Value = "path")]
        Path,
    }
}
