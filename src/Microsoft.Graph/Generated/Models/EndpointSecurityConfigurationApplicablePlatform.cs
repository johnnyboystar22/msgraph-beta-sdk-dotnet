using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The endpoint security configuration applicable platform.</summary>
    public enum EndpointSecurityConfigurationApplicablePlatform {
        /// <summary>Unknown.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>MacOS.</summary>
        [EnumMember(Value = "macOS")]
        MacOS,
        /// <summary>Windows 10 and later.</summary>
        [EnumMember(Value = "windows10AndLater")]
        Windows10AndLater,
        /// <summary>Windows 10 and Windows Server.</summary>
        [EnumMember(Value = "windows10AndWindowsServer")]
        Windows10AndWindowsServer,
    }
}
