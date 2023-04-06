using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Search {
    public enum AnswerState {
        [EnumMember(Value = "published")]
        Published,
        [EnumMember(Value = "draft")]
        Draft,
        [EnumMember(Value = "excluded")]
        Excluded,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
