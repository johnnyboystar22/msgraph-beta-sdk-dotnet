using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum RuleMode {
        [EnumMember(Value = "audit")]
        Audit,
        [EnumMember(Value = "auditAndNotify")]
        AuditAndNotify,
        [EnumMember(Value = "enforce")]
        Enforce,
        [EnumMember(Value = "pendingDeletion")]
        PendingDeletion,
        [EnumMember(Value = "test")]
        Test,
    }
}
