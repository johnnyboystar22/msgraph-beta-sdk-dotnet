using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum PlannerRelationshipUserRoles {
        [EnumMember(Value = "defaultRules")]
        DefaultRules,
        [EnumMember(Value = "groupOwners")]
        GroupOwners,
        [EnumMember(Value = "groupMembers")]
        GroupMembers,
        [EnumMember(Value = "taskAssignees")]
        TaskAssignees,
        [EnumMember(Value = "applications")]
        Applications,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
