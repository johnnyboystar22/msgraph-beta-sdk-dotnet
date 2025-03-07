// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>An enum representing possible values for account use in work profile.</summary>
    public enum AndroidWorkProfileAccountUse
    {
        /// <summary>Allow additon of all accounts except Google accounts in Android Work Profile.</summary>
        [EnumMember(Value = "allowAllExceptGoogleAccounts")]
        AllowAllExceptGoogleAccounts,
        /// <summary>Block any account from being added in Android Work Profile. </summary>
        [EnumMember(Value = "blockAll")]
        BlockAll,
        /// <summary>Allow addition of all accounts (including Google accounts) in Android Work Profile.</summary>
        [EnumMember(Value = "allowAll")]
        AllowAll,
        /// <summary>Unknown future value for evolvable enum patterns.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
