using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Defender TamperProtection setting options</summary>
    public enum WindowsDefenderTamperProtectionOptions {
        /// <summary>Not Configured</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Enable windows defender tamper protection</summary>
        [EnumMember(Value = "enable")]
        Enable,
        /// <summary>Disable windows defender tamper protection</summary>
        [EnumMember(Value = "disable")]
        Disable,
    }
}
