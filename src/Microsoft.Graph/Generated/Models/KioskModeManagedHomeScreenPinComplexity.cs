using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Complexity of PIN for Managed Home Screen sign-in session.</summary>
    public enum KioskModeManagedHomeScreenPinComplexity {
        /// <summary>Not configured.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Numeric values only.</summary>
        [EnumMember(Value = "simple")]
        Simple,
        /// <summary>Alphanumerical value.</summary>
        [EnumMember(Value = "complex")]
        Complex,
    }
}
