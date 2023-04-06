using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum AppleUserInitiatedEnrollmentType {
        /// <summary>Default value in case enum parsing fails</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Device enrollment via the iOS Company Portal. The default user-initiated enrollment type, which does not segregate corporate and personal data. Supported on all Intune-supported iOS/iPadOS versions.</summary>
        [EnumMember(Value = "device")]
        Device,
        /// <summary>Profile-driven user enrollment via the iOS Company Portal. An enrollment type that segregates corportate and personal data. Supported on devices running iOS/iPadOS 13 and higher.</summary>
        [EnumMember(Value = "user")]
        User,
        /// <summary>Account-driven user enrollment. Users will enroll from the iOS Settings app without using the iOS Company Portal. This enrollment type segregates corporate and personal data. Supported on devices running iOS/iPadOS 15 and higher.</summary>
        [EnumMember(Value = "accountDrivenUserEnrollment")]
        AccountDrivenUserEnrollment,
        /// <summary>Device enrollment via the web. Users will enroll without using the iOS Company Portal. This enrollment type does not segregate corporate and personal data. Supported on all Intune-supported iOS/iPadOS versions.</summary>
        [EnumMember(Value = "webDeviceEnrollment")]
        WebDeviceEnrollment,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
