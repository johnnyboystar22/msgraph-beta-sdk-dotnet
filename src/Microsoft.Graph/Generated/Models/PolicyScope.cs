using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum PolicyScope {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "selected")]
        Selected,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
