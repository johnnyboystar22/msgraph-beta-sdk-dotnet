using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public enum TenantOnboardingStatus {
        [EnumMember(Value = "ineligible")]
        Ineligible,
        [EnumMember(Value = "inProcess")]
        InProcess,
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "inactive")]
        Inactive,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
