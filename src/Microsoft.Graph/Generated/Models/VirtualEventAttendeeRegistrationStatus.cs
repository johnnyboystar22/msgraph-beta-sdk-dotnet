using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum VirtualEventAttendeeRegistrationStatus {
        [EnumMember(Value = "registered")]
        Registered,
        [EnumMember(Value = "canceled")]
        Canceled,
        [EnumMember(Value = "waitlisted")]
        Waitlisted,
        [EnumMember(Value = "pendingApproval")]
        PendingApproval,
        [EnumMember(Value = "rejectedByOrganizer")]
        RejectedByOrganizer,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
