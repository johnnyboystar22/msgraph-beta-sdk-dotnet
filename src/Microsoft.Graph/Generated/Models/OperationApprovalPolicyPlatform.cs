// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>The set of available platforms for the OperationApprovalPolicy. Allows configuration of a policy to specific platform(s) for approval. If no specific platform is required or applicable, the platform is `notApplicable`.</summary>
    [Flags]
    public enum OperationApprovalPolicyPlatform
    {
        /// <summary>Default. Indicates that a policy platform is not required for a chosen policy type.</summary>
        [EnumMember(Value = "notApplicable")]
        NotApplicable = 1,
        /// <summary>Indicates that the configured policy platform is for Android Device Administrator.</summary>
        [EnumMember(Value = "androidDeviceAdministrator")]
        AndroidDeviceAdministrator = 2,
        /// <summary>Indicates that the configured policy platform is for Android Enterprise.</summary>
        [EnumMember(Value = "androidEnterprise")]
        AndroidEnterprise = 4,
        /// <summary>Indicates that the configured policy platform is for iOS/iPadOS.</summary>
        [EnumMember(Value = "iOSiPadOS")]
        IOSiPadOS = 8,
        /// <summary>Indicates that the configured policy platform is for macOS.</summary>
        [EnumMember(Value = "macOS")]
        MacOS = 16,
        /// <summary>Indicates that the configured policy platform is for Windows 10 and later.</summary>
        [EnumMember(Value = "windows10AndLater")]
        Windows10AndLater = 32,
        /// <summary>Indicates that the configured policy platform is for Windows 8.1 and later.</summary>
        [EnumMember(Value = "windows81AndLater")]
        Windows81AndLater = 64,
        /// <summary>Indicates that the configured policy platform is for Windows 10X.</summary>
        [EnumMember(Value = "windows10X")]
        Windows10X = 128,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue = 256,
    }
}
