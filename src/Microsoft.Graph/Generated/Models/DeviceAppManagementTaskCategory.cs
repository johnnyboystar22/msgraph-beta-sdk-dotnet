using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Device app management task category.</summary>
    public enum DeviceAppManagementTaskCategory {
        /// <summary>Unknown source.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Windows Defender ATP Threat &amp; Vulnerability Management.</summary>
        [EnumMember(Value = "advancedThreatProtection")]
        AdvancedThreatProtection,
    }
}
