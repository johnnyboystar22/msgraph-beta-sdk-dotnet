using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum SimulationAutomationStatus {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "draft")]
        Draft,
        [EnumMember(Value = "notRunning")]
        NotRunning,
        [EnumMember(Value = "running")]
        Running,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
