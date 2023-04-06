using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Android Device Owner Kiosk Mode managed home screen virtual home button type.</summary>
    public enum AndroidDeviceOwnerVirtualHomeButtonType {
        /// <summary>Not configured; this value is ignored.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Swipe-up for home button.</summary>
        [EnumMember(Value = "swipeUp")]
        SwipeUp,
        /// <summary>Floating home button.</summary>
        [EnumMember(Value = "floating")]
        Floating,
    }
}
