using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>App source options for macOS Gatekeeper.</summary>
    public enum MacOSGatekeeperAppSources {
        /// <summary>Device default value, no intent.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Only apps from the Mac AppStore can be run.</summary>
        [EnumMember(Value = "macAppStore")]
        MacAppStore,
        /// <summary>Only apps from the Mac AppStore and identified developers can be run.</summary>
        [EnumMember(Value = "macAppStoreAndIdentifiedDevelopers")]
        MacAppStoreAndIdentifiedDevelopers,
        /// <summary>Apps from anywhere can be run.</summary>
        [EnumMember(Value = "anywhere")]
        Anywhere,
    }
}
