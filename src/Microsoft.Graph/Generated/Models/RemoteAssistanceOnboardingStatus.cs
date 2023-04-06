using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The current TeamViewer connector status</summary>
    public enum RemoteAssistanceOnboardingStatus {
        /// <summary>The status reported when there is no active TeamViewer connector configured or active</summary>
        [EnumMember(Value = "notOnboarded")]
        NotOnboarded,
        /// <summary>The status reported when the system has initiated a TeamViewer connection, but the service has not yet completed the confirmation of a connector</summary>
        [EnumMember(Value = "onboarding")]
        Onboarding,
        /// <summary>The status reported when the system has successfully exchanged account information with TeamViewer and can now initiate remote assistance sessions with clients</summary>
        [EnumMember(Value = "onboarded")]
        Onboarded,
    }
}
