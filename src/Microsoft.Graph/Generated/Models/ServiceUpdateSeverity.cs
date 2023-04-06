using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ServiceUpdateSeverity {
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "high")]
        High,
        [EnumMember(Value = "critical")]
        Critical,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
