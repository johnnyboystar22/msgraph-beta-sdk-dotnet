using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Possible values for username source or email source.</summary>
    public enum UserEmailSource {
        /// <summary>User principal name.</summary>
        [EnumMember(Value = "userPrincipalName")]
        UserPrincipalName,
        /// <summary>Primary SMTP address.</summary>
        [EnumMember(Value = "primarySmtpAddress")]
        PrimarySmtpAddress,
    }
}
