using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Username source.</summary>
    public enum UsernameSource {
        /// <summary>User principal name.</summary>
        [EnumMember(Value = "userPrincipalName")]
        UserPrincipalName,
        /// <summary>Primary SMTP address.</summary>
        [EnumMember(Value = "primarySmtpAddress")]
        PrimarySmtpAddress,
        /// <summary>The user sam account name.</summary>
        [EnumMember(Value = "samAccountName")]
        SamAccountName,
    }
}
