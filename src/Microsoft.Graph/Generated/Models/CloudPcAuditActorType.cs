using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CloudPcAuditActorType {
        [EnumMember(Value = "itPro")]
        ItPro,
        [EnumMember(Value = "application")]
        Application,
        [EnumMember(Value = "partner")]
        Partner,
        [EnumMember(Value = "unknown")]
        Unknown,
    }
}
