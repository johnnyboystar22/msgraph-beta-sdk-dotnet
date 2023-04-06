using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Which branch devices will receive their updates from</summary>
    public enum WindowsUpdateType {
        /// <summary>Allow the user to set.</summary>
        [EnumMember(Value = "userDefined")]
        UserDefined,
        /// <summary>Semi-annual Channel (Targeted). Device gets all applicable feature updates from Semi-annual Channel (Targeted).</summary>
        [EnumMember(Value = "all")]
        All,
        /// <summary>Semi-annual Channel. Device gets feature updates from Semi-annual Channel.</summary>
        [EnumMember(Value = "businessReadyOnly")]
        BusinessReadyOnly,
        /// <summary>Windows Insider build - Fast</summary>
        [EnumMember(Value = "windowsInsiderBuildFast")]
        WindowsInsiderBuildFast,
        /// <summary>Windows Insider build - Slow</summary>
        [EnumMember(Value = "windowsInsiderBuildSlow")]
        WindowsInsiderBuildSlow,
        /// <summary>Release Windows Insider build</summary>
        [EnumMember(Value = "windowsInsiderBuildRelease")]
        WindowsInsiderBuildRelease,
    }
}
