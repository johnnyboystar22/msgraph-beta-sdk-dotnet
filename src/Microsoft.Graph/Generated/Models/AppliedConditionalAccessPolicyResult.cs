using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum AppliedConditionalAccessPolicyResult {
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "failure")]
        Failure,
        [EnumMember(Value = "notApplied")]
        NotApplied,
        [EnumMember(Value = "notEnabled")]
        NotEnabled,
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "reportOnlySuccess")]
        ReportOnlySuccess,
        [EnumMember(Value = "reportOnlyFailure")]
        ReportOnlyFailure,
        [EnumMember(Value = "reportOnlyNotApplied")]
        ReportOnlyNotApplied,
        [EnumMember(Value = "reportOnlyInterrupted")]
        ReportOnlyInterrupted,
    }
}
