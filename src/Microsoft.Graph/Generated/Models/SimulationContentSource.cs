using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum SimulationContentSource {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "global")]
        Global,
        [EnumMember(Value = "tenant")]
        Tenant,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
