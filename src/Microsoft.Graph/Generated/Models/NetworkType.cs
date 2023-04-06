using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum NetworkType {
        [EnumMember(Value = "intranet")]
        Intranet,
        [EnumMember(Value = "extranet")]
        Extranet,
        [EnumMember(Value = "namedNetwork")]
        NamedNetwork,
        [EnumMember(Value = "trusted")]
        Trusted,
        [EnumMember(Value = "trustedNamedLocation")]
        TrustedNamedLocation,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
