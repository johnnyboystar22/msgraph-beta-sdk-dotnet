using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum PrintEvent {
        [EnumMember(Value = "jobStarted")]
        JobStarted,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
