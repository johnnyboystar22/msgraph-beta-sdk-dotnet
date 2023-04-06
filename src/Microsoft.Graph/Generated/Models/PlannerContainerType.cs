using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum PlannerContainerType {
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "roster")]
        Roster,
        [EnumMember(Value = "project")]
        Project,
        [EnumMember(Value = "driveItem")]
        DriveItem,
    }
}
