using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CountryLookupMethodType {
        [EnumMember(Value = "clientIpAddress")]
        ClientIpAddress,
        [EnumMember(Value = "authenticatorAppGps")]
        AuthenticatorAppGps,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
