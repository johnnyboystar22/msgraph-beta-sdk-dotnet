using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum EnrollmentState {
        /// <summary>Device enrollment state is unknown</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Device is Enrolled.</summary>
        [EnumMember(Value = "enrolled")]
        Enrolled,
        /// <summary>Enrolled but it&apos;s enrolled via enrollment profile and the enrolled profile is different from the assigned profile.</summary>
        [EnumMember(Value = "pendingReset")]
        PendingReset,
        /// <summary>Not enrolled and there is enrollment failure record.</summary>
        [EnumMember(Value = "failed")]
        Failed,
        /// <summary>Device is imported but not enrolled.</summary>
        [EnumMember(Value = "notContacted")]
        NotContacted,
        /// <summary>Device is enrolled as userless, but is blocked from moving to user enrollment because the app failed to install.</summary>
        [EnumMember(Value = "blocked")]
        Blocked,
    }
}
