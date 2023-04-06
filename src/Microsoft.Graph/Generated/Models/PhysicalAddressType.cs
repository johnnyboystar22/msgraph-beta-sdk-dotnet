using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum PhysicalAddressType {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "home")]
        Home,
        [EnumMember(Value = "business")]
        Business,
        [EnumMember(Value = "other")]
        Other,
    }
}
