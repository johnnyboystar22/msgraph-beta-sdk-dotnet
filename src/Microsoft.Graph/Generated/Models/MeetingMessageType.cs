using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum MeetingMessageType {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "meetingRequest")]
        MeetingRequest,
        [EnumMember(Value = "meetingCancelled")]
        MeetingCancelled,
        [EnumMember(Value = "meetingAccepted")]
        MeetingAccepted,
        [EnumMember(Value = "meetingTentativelyAccepted")]
        MeetingTentativelyAccepted,
        [EnumMember(Value = "meetingDeclined")]
        MeetingDeclined,
    }
}
