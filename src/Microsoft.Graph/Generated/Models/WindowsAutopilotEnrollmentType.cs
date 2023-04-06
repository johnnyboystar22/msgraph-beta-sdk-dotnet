using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum WindowsAutopilotEnrollmentType {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "azureADJoinedWithAutopilotProfile")]
        AzureADJoinedWithAutopilotProfile,
        [EnumMember(Value = "offlineDomainJoined")]
        OfflineDomainJoined,
        [EnumMember(Value = "azureADJoinedUsingDeviceAuthWithAutopilotProfile")]
        AzureADJoinedUsingDeviceAuthWithAutopilotProfile,
        [EnumMember(Value = "azureADJoinedUsingDeviceAuthWithoutAutopilotProfile")]
        AzureADJoinedUsingDeviceAuthWithoutAutopilotProfile,
        [EnumMember(Value = "azureADJoinedWithOfflineAutopilotProfile")]
        AzureADJoinedWithOfflineAutopilotProfile,
        [EnumMember(Value = "azureADJoinedWithWhiteGlove")]
        AzureADJoinedWithWhiteGlove,
        [EnumMember(Value = "offlineDomainJoinedWithWhiteGlove")]
        OfflineDomainJoinedWithWhiteGlove,
        [EnumMember(Value = "offlineDomainJoinedWithOfflineAutopilotProfile")]
        OfflineDomainJoinedWithOfflineAutopilotProfile,
    }
}
