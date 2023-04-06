using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum EducationUserRole {
        [EnumMember(Value = "student")]
        Student,
        [EnumMember(Value = "teacher")]
        Teacher,
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "faculty")]
        Faculty,
    }
}
