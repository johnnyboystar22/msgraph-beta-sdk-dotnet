using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum SimulationAttackType {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "social")]
        Social,
        [EnumMember(Value = "cloud")]
        Cloud,
        [EnumMember(Value = "endpoint")]
        Endpoint,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
