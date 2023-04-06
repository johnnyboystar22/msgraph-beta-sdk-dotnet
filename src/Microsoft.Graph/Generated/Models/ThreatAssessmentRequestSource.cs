using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ThreatAssessmentRequestSource {
        [EnumMember(Value = "undefined")]
        Undefined,
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "administrator")]
        Administrator,
    }
}
