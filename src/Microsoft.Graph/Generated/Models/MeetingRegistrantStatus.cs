using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum MeetingRegistrantStatus {
        [EnumMember(Value = "registered")]
        Registered,
        [EnumMember(Value = "canceled")]
        Canceled,
        [EnumMember(Value = "processing")]
        Processing,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
