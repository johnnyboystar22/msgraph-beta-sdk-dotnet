using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum AuthenticationContextDetail {
        [EnumMember(Value = "required")]
        Required,
        [EnumMember(Value = "previouslySatisfied")]
        PreviouslySatisfied,
        [EnumMember(Value = "notApplicable")]
        NotApplicable,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
