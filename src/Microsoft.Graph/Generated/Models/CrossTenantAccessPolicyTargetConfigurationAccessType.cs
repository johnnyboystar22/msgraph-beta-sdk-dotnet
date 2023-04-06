using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CrossTenantAccessPolicyTargetConfigurationAccessType {
        [EnumMember(Value = "allowed")]
        Allowed,
        [EnumMember(Value = "blocked")]
        Blocked,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
