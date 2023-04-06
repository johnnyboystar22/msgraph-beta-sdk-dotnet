using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum Mutability {
        [EnumMember(Value = "ReadWrite")]
        ReadWrite,
        [EnumMember(Value = "ReadOnly")]
        ReadOnly,
        [EnumMember(Value = "Immutable")]
        Immutable,
        [EnumMember(Value = "WriteOnly")]
        WriteOnly,
    }
}
