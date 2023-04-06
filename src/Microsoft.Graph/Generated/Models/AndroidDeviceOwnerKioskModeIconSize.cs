using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Android Device Owner Kiosk Mode managed home screen icon size.</summary>
    public enum AndroidDeviceOwnerKioskModeIconSize {
        /// <summary>Not configured; this value is ignored.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Smallest icon size.</summary>
        [EnumMember(Value = "smallest")]
        Smallest,
        /// <summary>Small icon size.</summary>
        [EnumMember(Value = "small")]
        Small,
        /// <summary>Regular icon size.</summary>
        [EnumMember(Value = "regular")]
        Regular,
        /// <summary>Large icon size.</summary>
        [EnumMember(Value = "large")]
        Large,
        /// <summary>Largest icon size.</summary>
        [EnumMember(Value = "largest")]
        Largest,
    }
}
