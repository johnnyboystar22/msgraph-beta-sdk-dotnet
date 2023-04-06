using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.CallRecords {
    public enum PstnUserBlockMode {
        [EnumMember(Value = "blocked")]
        Blocked,
        [EnumMember(Value = "unblocked")]
        Unblocked,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
