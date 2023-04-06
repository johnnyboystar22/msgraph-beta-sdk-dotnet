using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum PrivilegedAccessGroupAssignmentType {
        [EnumMember(Value = "assigned")]
        Assigned,
        [EnumMember(Value = "activated")]
        Activated,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
