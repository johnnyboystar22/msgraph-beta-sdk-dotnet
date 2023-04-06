using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.ExternalConnectors {
    public enum IdentityType {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "externalGroup")]
        ExternalGroup,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
