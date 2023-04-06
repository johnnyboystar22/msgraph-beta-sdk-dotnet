using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum KerberosSignOnMappingAttributeType {
        [EnumMember(Value = "userPrincipalName")]
        UserPrincipalName,
        [EnumMember(Value = "onPremisesUserPrincipalName")]
        OnPremisesUserPrincipalName,
        [EnumMember(Value = "userPrincipalUsername")]
        UserPrincipalUsername,
        [EnumMember(Value = "onPremisesUserPrincipalUsername")]
        OnPremisesUserPrincipalUsername,
        [EnumMember(Value = "onPremisesSAMAccountName")]
        OnPremisesSAMAccountName,
    }
}
