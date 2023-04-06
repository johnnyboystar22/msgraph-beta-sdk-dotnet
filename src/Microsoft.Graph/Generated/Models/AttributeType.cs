using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum AttributeType {
        [EnumMember(Value = "String")]
        String,
        [EnumMember(Value = "Integer")]
        Integer,
        [EnumMember(Value = "Reference")]
        Reference,
        [EnumMember(Value = "Binary")]
        Binary,
        [EnumMember(Value = "Boolean")]
        Boolean,
        [EnumMember(Value = "DateTime")]
        DateTime,
    }
}
