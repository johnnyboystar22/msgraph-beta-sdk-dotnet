using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ClientCredentialType {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "clientSecret")]
        ClientSecret,
        [EnumMember(Value = "clientAssertion")]
        ClientAssertion,
        [EnumMember(Value = "federatedIdentityCredential")]
        FederatedIdentityCredential,
        [EnumMember(Value = "managedIdentity")]
        ManagedIdentity,
        [EnumMember(Value = "certificate")]
        Certificate,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
