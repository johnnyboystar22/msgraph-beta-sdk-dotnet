using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Possible values of Android Kiosk Mode.</summary>
    public enum KioskModeType {
        /// <summary>Not configured</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Run in single-app mode</summary>
        [EnumMember(Value = "singleAppMode")]
        SingleAppMode,
        /// <summary>Run in multi-app mode</summary>
        [EnumMember(Value = "multiAppMode")]
        MultiAppMode,
    }
}
