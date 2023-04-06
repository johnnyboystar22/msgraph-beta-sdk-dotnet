using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Type of accounts that are allowed for Windows10SecureAssessment ConfigurationAccount.</summary>
    public enum SecureAssessmentAccountType {
        /// <summary>Indicates an Azure AD account in format of AzureAD\username@tenant.com.</summary>
        [EnumMember(Value = "azureADAccount")]
        AzureADAccount,
        /// <summary>Indicates a domain account in format of domain\user or user@domain.com.</summary>
        [EnumMember(Value = "domainAccount")]
        DomainAccount,
        /// <summary>Indicates a local account in format of username.</summary>
        [EnumMember(Value = "localAccount")]
        LocalAccount,
        /// <summary>Indicates a local guest account in format of test name.</summary>
        [EnumMember(Value = "localGuestAccount")]
        LocalGuestAccount,
    }
}
