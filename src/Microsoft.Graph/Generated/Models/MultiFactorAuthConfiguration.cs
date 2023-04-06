using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum MultiFactorAuthConfiguration {
        [EnumMember(Value = "notRequired")]
        NotRequired,
        [EnumMember(Value = "required")]
        Required,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
