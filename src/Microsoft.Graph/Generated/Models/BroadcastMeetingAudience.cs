using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum BroadcastMeetingAudience {
        [EnumMember(Value = "roleIsAttendee")]
        RoleIsAttendee,
        [EnumMember(Value = "organization")]
        Organization,
        [EnumMember(Value = "everyone")]
        Everyone,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
