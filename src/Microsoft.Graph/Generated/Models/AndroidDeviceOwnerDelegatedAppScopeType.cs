// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>An enum representing possible values for delegated app scope.</summary>
    public enum AndroidDeviceOwnerDelegatedAppScopeType
    {
        /// <summary>Unspecified; this value defaults to DELEGATED_SCOPE_UNSPECIFIED.</summary>
        [EnumMember(Value = "unspecified")]
        Unspecified,
        /// <summary>Specifies that the admin has given app permission to install and manage certificates on device.</summary>
        [EnumMember(Value = "certificateInstall")]
        CertificateInstall,
        /// <summary>Specifies that the admin has given app permission to capture network activity logs on device. More info on Network activity logs: https://developer.android.com/work/dpc/logging </summary>
        [EnumMember(Value = "captureNetworkActivityLog")]
        CaptureNetworkActivityLog,
        /// <summary>Specified that the admin has given permission to capture security logs on device. More info on Security logs: https://developer.android.com/work/dpc/security#log_enterprise_device_activity</summary>
        [EnumMember(Value = "captureSecurityLog")]
        CaptureSecurityLog,
        /// <summary>Unknown future value (reserved, not used right now)</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
