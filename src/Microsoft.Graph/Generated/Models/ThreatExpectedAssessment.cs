using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ThreatExpectedAssessment {
        [EnumMember(Value = "block")]
        Block,
        [EnumMember(Value = "unblock")]
        Unblock,
    }
}
