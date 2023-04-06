using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum AccessPackageCustomExtensionHandlerStatus {
        [EnumMember(Value = "requestSent")]
        RequestSent,
        [EnumMember(Value = "requestReceived")]
        RequestReceived,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
