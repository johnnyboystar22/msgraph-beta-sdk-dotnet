using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum Priority {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "High")]
        High,
        [EnumMember(Value = "Low")]
        Low,
    }
}
