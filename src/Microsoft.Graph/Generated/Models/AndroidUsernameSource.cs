using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Android username source.</summary>
    public enum AndroidUsernameSource {
        /// <summary>The username.</summary>
        [EnumMember(Value = "username")]
        Username,
        /// <summary>The user principal name.</summary>
        [EnumMember(Value = "userPrincipalName")]
        UserPrincipalName,
        /// <summary>The user sam account name.</summary>
        [EnumMember(Value = "samAccountName")]
        SamAccountName,
        /// <summary>Primary SMTP address.</summary>
        [EnumMember(Value = "primarySmtpAddress")]
        PrimarySmtpAddress,
    }
}
