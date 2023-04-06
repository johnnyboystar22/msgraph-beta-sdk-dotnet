using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Options available for enrollment flow customization</summary>
    public enum EnrollmentAvailabilityOptions {
        /// <summary>Device enrollment flow is shown to the end user with guided enrollment prompts</summary>
        [EnumMember(Value = "availableWithPrompts")]
        AvailableWithPrompts,
        /// <summary>Device enrollment flow is available to the end user without guided enrollment prompts</summary>
        [EnumMember(Value = "availableWithoutPrompts")]
        AvailableWithoutPrompts,
        /// <summary>Device enrollment flow is unavailable to the enduser</summary>
        [EnumMember(Value = "unavailable")]
        Unavailable,
    }
}
