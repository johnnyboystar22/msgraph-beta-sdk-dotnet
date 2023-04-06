using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum SingleSignOnMode {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "onPremisesKerberos")]
        OnPremisesKerberos,
        [EnumMember(Value = "saml")]
        Saml,
        [EnumMember(Value = "pingHeaderBased")]
        PingHeaderBased,
        [EnumMember(Value = "aadHeaderBased")]
        AadHeaderBased,
        [EnumMember(Value = "oAuthToken")]
        OAuthToken,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
