using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CloudPcAuditActivityOperationType {
        [EnumMember(Value = "create")]
        Create,
        [EnumMember(Value = "delete")]
        Delete,
        [EnumMember(Value = "patch")]
        Patch,
        [EnumMember(Value = "other")]
        Other,
    }
}
