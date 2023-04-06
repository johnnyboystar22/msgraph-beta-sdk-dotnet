using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Template subtype</summary>
    public enum DeviceManagementTemplateSubtype {
        /// <summary>Template has no subtype</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Endpoint security firewall subtype</summary>
        [EnumMember(Value = "firewall")]
        Firewall,
        /// <summary>Endpoint security disk encryption subtype</summary>
        [EnumMember(Value = "diskEncryption")]
        DiskEncryption,
        /// <summary>Endpoint security attack surface reduction subtype</summary>
        [EnumMember(Value = "attackSurfaceReduction")]
        AttackSurfaceReduction,
        /// <summary>Endpoint security endpoint detection and response subtype</summary>
        [EnumMember(Value = "endpointDetectionReponse")]
        EndpointDetectionReponse,
        /// <summary>Endpoint security account protection subtype</summary>
        [EnumMember(Value = "accountProtection")]
        AccountProtection,
        /// <summary>Endpoint security anitivirus subtype</summary>
        [EnumMember(Value = "antivirus")]
        Antivirus,
        /// <summary>Endpoint security firewall shared app subtype</summary>
        [EnumMember(Value = "firewallSharedAppList")]
        FirewallSharedAppList,
        /// <summary>Endpoint security firewall shared ip range list subtype</summary>
        [EnumMember(Value = "firewallSharedIpList")]
        FirewallSharedIpList,
        /// <summary>Endpoint security firewall shared port range list subtype</summary>
        [EnumMember(Value = "firewallSharedPortlist")]
        FirewallSharedPortlist,
    }
}
