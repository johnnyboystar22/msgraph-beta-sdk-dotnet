using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum OperationStatus {
        [EnumMember(Value = "NotStarted")]
        NotStarted,
        [EnumMember(Value = "Running")]
        Running,
        [EnumMember(Value = "Completed")]
        Completed,
        [EnumMember(Value = "Failed")]
        Failed,
    }
}
