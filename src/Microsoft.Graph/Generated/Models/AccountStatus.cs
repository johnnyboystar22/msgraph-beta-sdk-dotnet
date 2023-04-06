using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum AccountStatus {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "staged")]
        Staged,
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "suspended")]
        Suspended,
        [EnumMember(Value = "deleted")]
        Deleted,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
