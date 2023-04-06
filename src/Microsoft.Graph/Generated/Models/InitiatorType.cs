using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum InitiatorType {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "application")]
        Application,
        [EnumMember(Value = "system")]
        System,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
