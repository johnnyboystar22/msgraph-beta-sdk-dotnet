using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum TeamworkConversationIdentityType {
        [EnumMember(Value = "team")]
        Team,
        [EnumMember(Value = "channel")]
        Channel,
        [EnumMember(Value = "chat")]
        Chat,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
