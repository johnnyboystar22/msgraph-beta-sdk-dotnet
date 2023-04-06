using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum EducationAddedStudentAction {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "assignIfOpen")]
        AssignIfOpen,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
