using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum TeamworkConnectionStatus {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "connected")]
        Connected,
        [EnumMember(Value = "disconnected")]
        Disconnected,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
