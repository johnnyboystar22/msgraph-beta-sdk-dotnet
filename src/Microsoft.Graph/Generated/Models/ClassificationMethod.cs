using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ClassificationMethod {
        [EnumMember(Value = "patternMatch")]
        PatternMatch,
        [EnumMember(Value = "exactDataMatch")]
        ExactDataMatch,
        [EnumMember(Value = "fingerprint")]
        Fingerprint,
        [EnumMember(Value = "machineLearning")]
        MachineLearning,
    }
}
