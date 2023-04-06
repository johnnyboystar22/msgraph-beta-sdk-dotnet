using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public enum ManagementTemplateDeploymentStatus {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "inProgress")]
        InProgress,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "ineligible")]
        Ineligible,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
