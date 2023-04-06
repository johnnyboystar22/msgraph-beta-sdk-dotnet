using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum MeetingChatHistoryDefaultMode {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
