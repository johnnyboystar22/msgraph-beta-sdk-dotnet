using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum AccessPackageCustomExtensionStage {
        [EnumMember(Value = "assignmentRequestCreated")]
        AssignmentRequestCreated,
        [EnumMember(Value = "assignmentRequestApproved")]
        AssignmentRequestApproved,
        [EnumMember(Value = "assignmentRequestGranted")]
        AssignmentRequestGranted,
        [EnumMember(Value = "assignmentRequestRemoved")]
        AssignmentRequestRemoved,
        [EnumMember(Value = "assignmentFourteenDaysBeforeExpiration")]
        AssignmentFourteenDaysBeforeExpiration,
        [EnumMember(Value = "assignmentOneDayBeforeExpiration")]
        AssignmentOneDayBeforeExpiration,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
