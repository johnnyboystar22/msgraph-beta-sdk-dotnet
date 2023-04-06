using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum EducationAssignmentStatus {
        [EnumMember(Value = "draft")]
        Draft,
        [EnumMember(Value = "published")]
        Published,
        [EnumMember(Value = "assigned")]
        Assigned,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
