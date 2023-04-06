using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Possible values to specify which cookies are allowed in Microsoft Edge.</summary>
    public enum EdgeCookiePolicy {
        /// <summary>Allow the user to set.</summary>
        [EnumMember(Value = "userDefined")]
        UserDefined,
        /// <summary>Allow.</summary>
        [EnumMember(Value = "allow")]
        Allow,
        /// <summary>Block only third party cookies.</summary>
        [EnumMember(Value = "blockThirdParty")]
        BlockThirdParty,
        /// <summary>Block all cookies.</summary>
        [EnumMember(Value = "blockAll")]
        BlockAll,
    }
}
