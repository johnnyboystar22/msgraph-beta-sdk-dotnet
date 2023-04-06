using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public enum ManagementActionStatus {
        [EnumMember(Value = "toAddress")]
        ToAddress,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "error")]
        Error,
        [EnumMember(Value = "timeOut")]
        TimeOut,
        [EnumMember(Value = "inProgress")]
        InProgress,
        [EnumMember(Value = "planned")]
        Planned,
        [EnumMember(Value = "resolvedBy3rdParty")]
        ResolvedBy3rdParty,
        [EnumMember(Value = "resolvedThroughAlternateMitigation")]
        ResolvedThroughAlternateMitigation,
        [EnumMember(Value = "riskAccepted")]
        RiskAccepted,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
