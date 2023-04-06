using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>An enum representing possible values for cross profile data sharing.</summary>
    public enum AndroidDeviceOwnerCrossProfileDataSharing {
        /// <summary>Not configured; this value defaults to CROSS_PROFILE_DATA_SHARING_UNSPECIFIED.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Data cannot be shared from both the personal profile to work profile and the work profile to the personal profile.</summary>
        [EnumMember(Value = "crossProfileDataSharingBlocked")]
        CrossProfileDataSharingBlocked,
        /// <summary>Prevents users from sharing data from the work profile to apps in the personal profile. Personal data can be shared with work apps.</summary>
        [EnumMember(Value = "dataSharingFromWorkToPersonalBlocked")]
        DataSharingFromWorkToPersonalBlocked,
        /// <summary>Data from either profile can be shared with the other profile.</summary>
        [EnumMember(Value = "crossProfileDataSharingAllowed")]
        CrossProfileDataSharingAllowed,
        /// <summary>Unknown future value (reserved, not used right now)</summary>
        [EnumMember(Value = "unkownFutureValue")]
        UnkownFutureValue,
    }
}
