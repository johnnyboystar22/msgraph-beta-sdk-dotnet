using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public enum DeploymentStateValue {
        [EnumMember(Value = "scheduled")]
        Scheduled,
        [EnumMember(Value = "offering")]
        Offering,
        [EnumMember(Value = "paused")]
        Paused,
        [EnumMember(Value = "faulted")]
        Faulted,
        [EnumMember(Value = "archived")]
        Archived,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
