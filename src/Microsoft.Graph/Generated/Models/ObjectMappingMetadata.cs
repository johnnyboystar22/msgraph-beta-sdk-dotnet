using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ObjectMappingMetadata {
        [EnumMember(Value = "EscrowBehavior")]
        EscrowBehavior,
        [EnumMember(Value = "DisableMonitoringForChanges")]
        DisableMonitoringForChanges,
        [EnumMember(Value = "OriginalJoiningProperty")]
        OriginalJoiningProperty,
        [EnumMember(Value = "Disposition")]
        Disposition,
        [EnumMember(Value = "IsCustomerDefined")]
        IsCustomerDefined,
        [EnumMember(Value = "ExcludeFromReporting")]
        ExcludeFromReporting,
        [EnumMember(Value = "Unsynchronized")]
        Unsynchronized,
    }
}
