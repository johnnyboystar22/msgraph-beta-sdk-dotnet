using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum GroupPrivacy {
        [EnumMember(Value = "unspecified")]
        Unspecified,
        [EnumMember(Value = "public")]
        Public,
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
