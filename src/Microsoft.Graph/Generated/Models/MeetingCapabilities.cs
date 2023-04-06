using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum MeetingCapabilities {
        [EnumMember(Value = "questionAndAnswer")]
        QuestionAndAnswer,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
