using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ConnectionOperationStatus {
        [EnumMember(Value = "unspecified")]
        Unspecified,
        [EnumMember(Value = "inprogress")]
        Inprogress,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "failed")]
        Failed,
    }
}
