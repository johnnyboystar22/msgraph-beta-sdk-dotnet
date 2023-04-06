using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum MeetingChatMode {
        [EnumMember(Value = "enabled")]
        Enabled,
        [EnumMember(Value = "disabled")]
        Disabled,
        [EnumMember(Value = "limited")]
        Limited,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
