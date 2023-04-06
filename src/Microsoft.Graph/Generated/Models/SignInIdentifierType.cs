using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum SignInIdentifierType {
        [EnumMember(Value = "userPrincipalName")]
        UserPrincipalName,
        [EnumMember(Value = "phoneNumber")]
        PhoneNumber,
        [EnumMember(Value = "proxyAddress")]
        ProxyAddress,
        [EnumMember(Value = "qrCode")]
        QrCode,
        [EnumMember(Value = "onPremisesUserPrincipalName")]
        OnPremisesUserPrincipalName,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
