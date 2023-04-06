using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum AuthenticationProtocol {
        [EnumMember(Value = "wsFed")]
        WsFed,
        [EnumMember(Value = "saml")]
        Saml,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
