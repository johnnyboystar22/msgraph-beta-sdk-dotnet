using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ApplicationMode {
        [EnumMember(Value = "manual")]
        Manual,
        [EnumMember(Value = "automatic")]
        Automatic,
        [EnumMember(Value = "recommended")]
        Recommended,
    }
}
