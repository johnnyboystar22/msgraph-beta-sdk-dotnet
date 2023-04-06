using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum TimeCardState {
        [EnumMember(Value = "clockedIn")]
        ClockedIn,
        [EnumMember(Value = "onBreak")]
        OnBreak,
        [EnumMember(Value = "clockedOut")]
        ClockedOut,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
