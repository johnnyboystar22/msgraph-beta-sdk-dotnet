using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public enum RequestedDeploymentStateValue {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "paused")]
        Paused,
        [EnumMember(Value = "archived")]
        Archived,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
