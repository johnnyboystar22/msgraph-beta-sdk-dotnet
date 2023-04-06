using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public enum DelegatedPrivilegeStatus {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "delegatedAdminPrivileges")]
        DelegatedAdminPrivileges,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "granularDelegatedAdminPrivileges")]
        GranularDelegatedAdminPrivileges,
        [EnumMember(Value = "delegatedAndGranularDelegetedAdminPrivileges")]
        DelegatedAndGranularDelegetedAdminPrivileges,
    }
}
