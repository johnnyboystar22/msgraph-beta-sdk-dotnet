using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum OnPremisesDirectorySynchronizationDeletionPreventionType {
        [EnumMember(Value = "disabled")]
        Disabled,
        [EnumMember(Value = "enabledForCount")]
        EnabledForCount,
        [EnumMember(Value = "enabledForPercentage")]
        EnabledForPercentage,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
