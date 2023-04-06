using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum TiAction {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "allow")]
        Allow,
        [EnumMember(Value = "block")]
        Block,
        [EnumMember(Value = "alert")]
        Alert,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
