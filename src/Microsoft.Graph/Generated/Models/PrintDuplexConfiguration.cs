using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum PrintDuplexConfiguration {
        [EnumMember(Value = "twoSidedLongEdge")]
        TwoSidedLongEdge,
        [EnumMember(Value = "twoSidedShortEdge")]
        TwoSidedShortEdge,
        [EnumMember(Value = "oneSided")]
        OneSided,
    }
}
