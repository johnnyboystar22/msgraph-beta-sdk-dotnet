using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Ediscovery {
    public enum ChildSelectability {
        [EnumMember(Value = "One")]
        One,
        [EnumMember(Value = "Many")]
        Many,
    }
}
