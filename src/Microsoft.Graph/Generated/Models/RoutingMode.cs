using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum RoutingMode {
        [EnumMember(Value = "oneToOne")]
        OneToOne,
        [EnumMember(Value = "multicast")]
        Multicast,
    }
}
