using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ChatType {
        [EnumMember(Value = "oneOnOne")]
        OneOnOne,
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "meeting")]
        Meeting,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
