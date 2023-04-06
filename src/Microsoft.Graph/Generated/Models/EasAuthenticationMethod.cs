using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Exchange Active Sync authentication method.</summary>
    public enum EasAuthenticationMethod {
        /// <summary>Authenticate with a username and password.</summary>
        [EnumMember(Value = "usernameAndPassword")]
        UsernameAndPassword,
        /// <summary>Authenticate with a certificate.</summary>
        [EnumMember(Value = "certificate")]
        Certificate,
        /// <summary>Authenticate with derived credential.</summary>
        [EnumMember(Value = "derivedCredential")]
        DerivedCredential,
    }
}
