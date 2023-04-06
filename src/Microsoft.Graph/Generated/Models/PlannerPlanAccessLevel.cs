using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum PlannerPlanAccessLevel {
        [EnumMember(Value = "readAccess")]
        ReadAccess,
        [EnumMember(Value = "readWriteAccess")]
        ReadWriteAccess,
        [EnumMember(Value = "fullAccess")]
        FullAccess,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
