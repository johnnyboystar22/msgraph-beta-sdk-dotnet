using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum SubmissionClientSource {
        [EnumMember(Value = "microsoft")]
        Microsoft,
        [EnumMember(Value = "other")]
        Other,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
