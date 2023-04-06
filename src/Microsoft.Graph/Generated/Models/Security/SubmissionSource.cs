using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum SubmissionSource {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "administrator")]
        Administrator,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
