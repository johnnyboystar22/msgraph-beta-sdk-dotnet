using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Possible values for LocalSecurityOptionsAdministratorElevationPromptBehavior</summary>
    public enum LocalSecurityOptionsAdministratorElevationPromptBehaviorType {
        /// <summary>Not Configured</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Elevate without prompting.</summary>
        [EnumMember(Value = "elevateWithoutPrompting")]
        ElevateWithoutPrompting,
        /// <summary>Prompt for credentials on the secure desktop</summary>
        [EnumMember(Value = "promptForCredentialsOnTheSecureDesktop")]
        PromptForCredentialsOnTheSecureDesktop,
        /// <summary>Prompt for consent on the secure desktop</summary>
        [EnumMember(Value = "promptForConsentOnTheSecureDesktop")]
        PromptForConsentOnTheSecureDesktop,
        /// <summary>Prompt for credentials</summary>
        [EnumMember(Value = "promptForCredentials")]
        PromptForCredentials,
        /// <summary>Prompt for consent</summary>
        [EnumMember(Value = "promptForConsent")]
        PromptForConsent,
        /// <summary>Prompt for consent for non-Windows binaries</summary>
        [EnumMember(Value = "promptForConsentForNonWindowsBinaries")]
        PromptForConsentForNonWindowsBinaries,
    }
}
