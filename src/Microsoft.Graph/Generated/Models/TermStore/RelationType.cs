using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.TermStore {
    public enum RelationType {
        [EnumMember(Value = "pin")]
        Pin,
        [EnumMember(Value = "reuse")]
        Reuse,
    }
}
