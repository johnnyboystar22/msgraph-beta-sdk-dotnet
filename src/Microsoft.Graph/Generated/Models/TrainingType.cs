using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum TrainingType {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "phishing")]
        Phishing,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
