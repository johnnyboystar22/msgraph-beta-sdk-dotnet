using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public enum AzureADDeviceRegistrationErrorReason {
        [EnumMember(Value = "invalidGlobalDeviceId")]
        InvalidGlobalDeviceId,
        [EnumMember(Value = "invalidAzureADDeviceId")]
        InvalidAzureADDeviceId,
        [EnumMember(Value = "missingTrustType")]
        MissingTrustType,
        [EnumMember(Value = "invalidAzureADJoin")]
        InvalidAzureADJoin,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
