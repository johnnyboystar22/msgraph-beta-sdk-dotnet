using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The onboarding status of the tenant.</summary>
    public enum ChromeOSOnboardingStatus {
        /// <summary>Unknown</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>In progress</summary>
        [EnumMember(Value = "inprogress")]
        Inprogress,
        /// <summary>Onboarded</summary>
        [EnumMember(Value = "onboarded")]
        Onboarded,
        /// <summary>Failed</summary>
        [EnumMember(Value = "failed")]
        Failed,
        /// <summary>Offboarding</summary>
        [EnumMember(Value = "offboarding")]
        Offboarding,
        /// <summary>UnknownFutureValue</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
