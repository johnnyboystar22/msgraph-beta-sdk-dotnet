using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Enum values for the various WindowsDefenderApplicationControl supplemental policy deployment statuses.</summary>
    public enum WindowsDefenderApplicationControlSupplementalPolicyStatuses {
        /// <summary>The status of the WindowsDefenderApplicationControl supplemental policy is not known.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>The WindowsDefenderApplicationControl supplemental policy is in effect.</summary>
        [EnumMember(Value = "success")]
        Success,
        /// <summary>The WindowsDefenderApplicationControl supplemental policy is structurally okay but there is an error with authorizing the token.</summary>
        [EnumMember(Value = "tokenError")]
        TokenError,
        /// <summary>The token does not authorize this WindowsDefenderApplicationControl supplemental policy.</summary>
        [EnumMember(Value = "notAuthorizedByToken")]
        NotAuthorizedByToken,
        /// <summary>The WindowsDefenderApplicationControl supplemental policy is not found.</summary>
        [EnumMember(Value = "policyNotFound")]
        PolicyNotFound,
    }
}
