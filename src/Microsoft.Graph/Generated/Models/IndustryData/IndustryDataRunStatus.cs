using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.IndustryData {
    public enum IndustryDataRunStatus {
        [EnumMember(Value = "running")]
        Running,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "completedWithErrors")]
        CompletedWithErrors,
        [EnumMember(Value = "completedWithWarnings")]
        CompletedWithWarnings,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
