using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum RestoreTimeRange {
        [EnumMember(Value = "before")]
        Before,
        [EnumMember(Value = "after")]
        After,
        [EnumMember(Value = "beforeOrAfter")]
        BeforeOrAfter,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
