using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ConditionalAccessPolicyState {
        [EnumMember(Value = "enabled")]
        Enabled,
        [EnumMember(Value = "disabled")]
        Disabled,
        [EnumMember(Value = "enabledForReportingButNotEnforced")]
        EnabledForReportingButNotEnforced,
    }
}
