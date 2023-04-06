using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.IndustryData {
    public enum IndustryDataActivityStatus {
        [EnumMember(Value = "inProgress")]
        InProgress,
        [EnumMember(Value = "skipped")]
        Skipped,
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
