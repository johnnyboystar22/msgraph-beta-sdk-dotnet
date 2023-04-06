using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum SubmissionCategory {
        [EnumMember(Value = "notJunk")]
        NotJunk,
        [EnumMember(Value = "spam")]
        Spam,
        [EnumMember(Value = "phishing")]
        Phishing,
        [EnumMember(Value = "malware")]
        Malware,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
