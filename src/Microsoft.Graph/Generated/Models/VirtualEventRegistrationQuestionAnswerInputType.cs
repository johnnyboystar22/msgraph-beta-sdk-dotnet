using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum VirtualEventRegistrationQuestionAnswerInputType {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "multilineText")]
        MultilineText,
        [EnumMember(Value = "singleChoice")]
        SingleChoice,
        [EnumMember(Value = "multiChoice")]
        MultiChoice,
        [EnumMember(Value = "boolean")]
        Boolean,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
