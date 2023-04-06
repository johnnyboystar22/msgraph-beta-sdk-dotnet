using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum DelegatedAdminRelationshipRequestAction {
        [EnumMember(Value = "lockForApproval")]
        LockForApproval,
        [EnumMember(Value = "approve")]
        Approve,
        [EnumMember(Value = "terminate")]
        Terminate,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
