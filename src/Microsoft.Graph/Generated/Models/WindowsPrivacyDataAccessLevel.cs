using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Determine the access level to specific Windows privacy data category.</summary>
    public enum WindowsPrivacyDataAccessLevel {
        /// <summary>No access level specified, no intents. Device may behave either as in UserInControl or ForceAllow. It may depend on the privacy data been accessed, Windows versions and other factors.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Apps will be allowed to access the specified privacy data.</summary>
        [EnumMember(Value = "forceAllow")]
        ForceAllow,
        /// <summary>Apps will be denied to access specified privacy data.</summary>
        [EnumMember(Value = "forceDeny")]
        ForceDeny,
        /// <summary>Users will be prompted when apps try to access specified privacy data.</summary>
        [EnumMember(Value = "userInControl")]
        UserInControl,
    }
}
