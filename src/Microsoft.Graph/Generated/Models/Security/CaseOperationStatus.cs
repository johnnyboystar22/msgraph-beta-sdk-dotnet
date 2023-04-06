using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum CaseOperationStatus {
        [EnumMember(Value = "notStarted")]
        NotStarted,
        [EnumMember(Value = "submissionFailed")]
        SubmissionFailed,
        [EnumMember(Value = "running")]
        Running,
        [EnumMember(Value = "succeeded")]
        Succeeded,
        [EnumMember(Value = "partiallySucceeded")]
        PartiallySucceeded,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
