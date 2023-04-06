using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Key Storage Provider (KSP) Import Options.</summary>
    public enum KeyStorageProviderOption {
        /// <summary>Import to Trusted Platform Module (TPM) KSP if present, otherwise import to Software KSP.</summary>
        [EnumMember(Value = "useTpmKspOtherwiseUseSoftwareKsp")]
        UseTpmKspOtherwiseUseSoftwareKsp,
        /// <summary>Import to Trusted Platform Module (TPM) KSP if present, otherwise fail.</summary>
        [EnumMember(Value = "useTpmKspOtherwiseFail")]
        UseTpmKspOtherwiseFail,
        /// <summary>Import to Passport for work KSP if available, otherwise fail.</summary>
        [EnumMember(Value = "usePassportForWorkKspOtherwiseFail")]
        UsePassportForWorkKspOtherwiseFail,
        /// <summary>Import to Software KSP.</summary>
        [EnumMember(Value = "useSoftwareKsp")]
        UseSoftwareKsp,
    }
}
