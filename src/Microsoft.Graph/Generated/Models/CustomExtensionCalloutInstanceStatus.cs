using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CustomExtensionCalloutInstanceStatus {
        [EnumMember(Value = "calloutSent")]
        CalloutSent,
        [EnumMember(Value = "callbackReceived")]
        CallbackReceived,
        [EnumMember(Value = "calloutFailed")]
        CalloutFailed,
        [EnumMember(Value = "callbackTimedOut")]
        CallbackTimedOut,
        [EnumMember(Value = "waitingForCallback")]
        WaitingForCallback,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
