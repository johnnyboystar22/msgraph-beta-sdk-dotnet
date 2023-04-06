using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum DiamondModel {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "adversary")]
        Adversary,
        [EnumMember(Value = "capability")]
        Capability,
        [EnumMember(Value = "infrastructure")]
        Infrastructure,
        [EnumMember(Value = "victim")]
        Victim,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
