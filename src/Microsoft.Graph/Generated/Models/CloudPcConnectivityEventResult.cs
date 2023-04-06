using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CloudPcConnectivityEventResult {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "failure")]
        Failure,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
