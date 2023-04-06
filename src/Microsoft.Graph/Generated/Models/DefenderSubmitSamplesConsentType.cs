using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Possible values for DefenderSubmitSamplesConsentType</summary>
    public enum DefenderSubmitSamplesConsentType {
        /// <summary>Send safe samples automatically</summary>
        [EnumMember(Value = "sendSafeSamplesAutomatically")]
        SendSafeSamplesAutomatically,
        /// <summary>Always prompt</summary>
        [EnumMember(Value = "alwaysPrompt")]
        AlwaysPrompt,
        /// <summary>Never send</summary>
        [EnumMember(Value = "neverSend")]
        NeverSend,
        /// <summary>Send all samples automatically</summary>
        [EnumMember(Value = "sendAllSamplesAutomatically")]
        SendAllSamplesAutomatically,
    }
}
