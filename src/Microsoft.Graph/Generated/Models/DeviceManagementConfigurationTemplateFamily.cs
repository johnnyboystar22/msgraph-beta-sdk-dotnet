using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Describes the TemplateFamily for the Template entity</summary>
    public enum DeviceManagementConfigurationTemplateFamily {
        /// <summary>Default for Template Family when Policy is not linked to a Template</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Template Family for EndpointSecurityAntivirus that manages the discrete group of antivirus settings for managed devices</summary>
        [EnumMember(Value = "endpointSecurityAntivirus")]
        EndpointSecurityAntivirus,
        /// <summary>Template Family for EndpointSecurityDiskEncryption that provides settings that are relevant for a devices built-in encryption  method, like FileVault or BitLocker</summary>
        [EnumMember(Value = "endpointSecurityDiskEncryption")]
        EndpointSecurityDiskEncryption,
        /// <summary>Template Family for EndpointSecurityFirewall that helps configure a devices built-in firewall for device that run macOS and Windows 10</summary>
        [EnumMember(Value = "endpointSecurityFirewall")]
        EndpointSecurityFirewall,
        /// <summary>Template Family for EndpointSecurityEndpointDetectionAndResponse that facilitates management of the EDR settings and onboard devices to Microsoft Defender for Endpoint</summary>
        [EnumMember(Value = "endpointSecurityEndpointDetectionAndResponse")]
        EndpointSecurityEndpointDetectionAndResponse,
        /// <summary>Template Family for EndpointSecurityAttackSurfaceReduction that help reduce your attack surfaces, by minimizing the places where your organization is vulnerable to cyberthreats and attacks</summary>
        [EnumMember(Value = "endpointSecurityAttackSurfaceReduction")]
        EndpointSecurityAttackSurfaceReduction,
        /// <summary>Template Family for EndpointSecurityAccountProtection that facilitates protecting the identity and accounts of users</summary>
        [EnumMember(Value = "endpointSecurityAccountProtection")]
        EndpointSecurityAccountProtection,
        /// <summary>Template Family for ApplicationControl that helps mitigate security threats by restricting the applications that users can run and the code that runs in the System Core (kernel)</summary>
        [EnumMember(Value = "endpointSecurityApplicationControl")]
        EndpointSecurityApplicationControl,
        /// <summary>Template Family for EPM Elevation Rules</summary>
        [EnumMember(Value = "endpointSecurityEndpointPrivilegeManagement")]
        EndpointSecurityEndpointPrivilegeManagement,
        /// <summary>Template Family for EnrollmentConfiguration</summary>
        [EnumMember(Value = "enrollmentConfiguration")]
        EnrollmentConfiguration,
        /// <summary>Template Family for QuietTimeIndicates Template Family for all the Apps QuietTime policies and templates</summary>
        [EnumMember(Value = "appQuietTime")]
        AppQuietTime,
        /// <summary>Template Family for Baseline</summary>
        [EnumMember(Value = "baseline")]
        Baseline,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        /// <summary>Template Family for device configuration scripts</summary>
        [EnumMember(Value = "deviceConfigurationScripts")]
        DeviceConfigurationScripts,
    }
}
