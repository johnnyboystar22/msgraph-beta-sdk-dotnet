using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Specify how the Microsoft Edge settings are restricted based on kiosk mode.</summary>
    public enum EdgeKioskModeRestrictionType {
        /// <summary>Not configured (unrestricted).</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Interactive/Digital signage in single-app mode.</summary>
        [EnumMember(Value = "digitalSignage")]
        DigitalSignage,
        /// <summary>Normal mode (full version of Microsoft Edge).</summary>
        [EnumMember(Value = "normalMode")]
        NormalMode,
        /// <summary>Public browsing in single-app mode.</summary>
        [EnumMember(Value = "publicBrowsingSingleApp")]
        PublicBrowsingSingleApp,
        /// <summary>Public browsing (inPrivate) in multi-app mode.</summary>
        [EnumMember(Value = "publicBrowsingMultiApp")]
        PublicBrowsingMultiApp,
    }
}
