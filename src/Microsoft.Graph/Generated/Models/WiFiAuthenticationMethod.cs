using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Wi-Fi authentication method.</summary>
    public enum WiFiAuthenticationMethod {
        /// <summary>Use an identity certificate for authentication.</summary>
        [EnumMember(Value = "certificate")]
        Certificate,
        /// <summary>Use username and password for authentication.</summary>
        [EnumMember(Value = "usernameAndPassword")]
        UsernameAndPassword,
        /// <summary>Use Derived Credential for authentication.</summary>
        [EnumMember(Value = "derivedCredential")]
        DerivedCredential,
    }
}
