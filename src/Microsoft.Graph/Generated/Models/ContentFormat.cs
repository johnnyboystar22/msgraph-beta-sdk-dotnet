using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ContentFormat {
        [EnumMember(Value = "default")]
        Default,
        [EnumMember(Value = "email")]
        Email,
    }
}
