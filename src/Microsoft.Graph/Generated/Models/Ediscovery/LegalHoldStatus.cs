using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Ediscovery {
    public enum LegalHoldStatus {
        [EnumMember(Value = "Pending")]
        Pending,
        [EnumMember(Value = "Error")]
        Error,
        [EnumMember(Value = "Success")]
        Success,
        [EnumMember(Value = "UnknownFutureValue")]
        UnknownFutureValue,
    }
}
