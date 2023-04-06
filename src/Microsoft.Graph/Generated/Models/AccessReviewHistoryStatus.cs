using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum AccessReviewHistoryStatus {
        [EnumMember(Value = "done")]
        Done,
        [EnumMember(Value = "inprogress")]
        Inprogress,
        [EnumMember(Value = "error")]
        Error,
        [EnumMember(Value = "requested")]
        Requested,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
