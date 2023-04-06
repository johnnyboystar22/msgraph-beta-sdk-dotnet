using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum PlannerExternalTaskSourceDisplayType {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "default")]
        Default,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
