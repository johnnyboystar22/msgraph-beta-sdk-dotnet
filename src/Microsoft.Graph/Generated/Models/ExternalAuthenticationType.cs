using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ExternalAuthenticationType {
        [EnumMember(Value = "passthru")]
        Passthru,
        [EnumMember(Value = "aadPreAuthentication")]
        AadPreAuthentication,
    }
}
