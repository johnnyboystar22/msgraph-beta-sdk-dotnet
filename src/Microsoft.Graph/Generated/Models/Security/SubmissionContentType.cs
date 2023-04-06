using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum SubmissionContentType {
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "url")]
        Url,
        [EnumMember(Value = "file")]
        File,
        [EnumMember(Value = "app")]
        App,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
