using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum DelegatedAdminAccessAssignmentStatus {
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "deleting")]
        Deleting,
        [EnumMember(Value = "deleted")]
        Deleted,
        [EnumMember(Value = "error")]
        Error,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
