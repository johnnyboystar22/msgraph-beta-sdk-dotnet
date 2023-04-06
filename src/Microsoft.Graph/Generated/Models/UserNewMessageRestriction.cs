using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum UserNewMessageRestriction {
        [EnumMember(Value = "everyone")]
        Everyone,
        [EnumMember(Value = "everyoneExceptGuests")]
        EveryoneExceptGuests,
        [EnumMember(Value = "moderators")]
        Moderators,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
