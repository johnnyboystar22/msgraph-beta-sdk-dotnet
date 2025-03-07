// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>The endpoint security policy type.</summary>
    public enum EndpointSecurityConfigurationType
    {
        /// <summary>Unknown.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Antivirus.</summary>
        [EnumMember(Value = "antivirus")]
        Antivirus,
        /// <summary>Disk encryption.</summary>
        [EnumMember(Value = "diskEncryption")]
        DiskEncryption,
        /// <summary>Firewall.</summary>
        [EnumMember(Value = "firewall")]
        Firewall,
        /// <summary>Endpoint detection and response.</summary>
        [EnumMember(Value = "endpointDetectionAndResponse")]
        EndpointDetectionAndResponse,
        /// <summary>Attack surface reduction.</summary>
        [EnumMember(Value = "attackSurfaceReduction")]
        AttackSurfaceReduction,
        /// <summary>Account protection.</summary>
        [EnumMember(Value = "accountProtection")]
        AccountProtection,
    }
}
