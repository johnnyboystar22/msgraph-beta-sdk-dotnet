using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Available settings for EAP-FAST Configuration.</summary>
    public enum EapFastConfiguration {
        /// <summary>Use EAP-FAST without Protected Access Credential (PAC).</summary>
        [EnumMember(Value = "noProtectedAccessCredential")]
        NoProtectedAccessCredential,
        /// <summary>Use Protected Access Credential (PAC).</summary>
        [EnumMember(Value = "useProtectedAccessCredential")]
        UseProtectedAccessCredential,
        /// <summary>Use Protected Access Credential (PAC) and Provision PAC.</summary>
        [EnumMember(Value = "useProtectedAccessCredentialAndProvision")]
        UseProtectedAccessCredentialAndProvision,
        /// <summary>Use Protected Access Credential (PAC), Provision PAC, and do so anonymously.</summary>
        [EnumMember(Value = "useProtectedAccessCredentialAndProvisionAnonymously")]
        UseProtectedAccessCredentialAndProvisionAnonymously,
    }
}
