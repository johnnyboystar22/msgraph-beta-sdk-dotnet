using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provider type for Derived Credentials.</summary>
    public enum DerivedCredentialProviderType {
        /// <summary>No Derived Credential Provider Configured.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Entrust.</summary>
        [EnumMember(Value = "entrustDataCard")]
        EntrustDataCard,
        /// <summary>Purebred - Defense Information Systems Agency.</summary>
        [EnumMember(Value = "purebred")]
        Purebred,
        /// <summary>Xtec - AuthentX.</summary>
        [EnumMember(Value = "xTec")]
        XTec,
        /// <summary>Intercede.</summary>
        [EnumMember(Value = "intercede")]
        Intercede,
    }
}
