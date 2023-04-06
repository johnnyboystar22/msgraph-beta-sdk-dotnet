using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Windows 10 VPN connection types.</summary>
    public enum Windows10VpnAuthenticationMethod {
        /// <summary>Authenticate with a certificate.</summary>
        [EnumMember(Value = "certificate")]
        Certificate,
        /// <summary>Use username and password for authentication.</summary>
        [EnumMember(Value = "usernameAndPassword")]
        UsernameAndPassword,
        /// <summary>Authentication method is specified in custom EAP XML.</summary>
        [EnumMember(Value = "customEapXml")]
        CustomEapXml,
        /// <summary>Use Derived Credential for authentication.</summary>
        [EnumMember(Value = "derivedCredential")]
        DerivedCredential,
    }
}
