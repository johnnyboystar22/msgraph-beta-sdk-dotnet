using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum DelegatedAdminRelationshipOperationType {
        [EnumMember(Value = "delegatedAdminAccessAssignmentUpdate")]
        DelegatedAdminAccessAssignmentUpdate,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
