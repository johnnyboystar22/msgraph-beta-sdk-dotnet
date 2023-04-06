using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public enum ResourceConnectionState {
        [EnumMember(Value = "connected")]
        Connected,
        [EnumMember(Value = "notAuthorized")]
        NotAuthorized,
        [EnumMember(Value = "notFound")]
        NotFound,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
