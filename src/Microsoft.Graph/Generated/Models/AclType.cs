using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum AclType {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "everyone")]
        Everyone,
        [EnumMember(Value = "everyoneExceptGuests")]
        EveryoneExceptGuests,
        [EnumMember(Value = "externalGroup")]
        ExternalGroup,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
