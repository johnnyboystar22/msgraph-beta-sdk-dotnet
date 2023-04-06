using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Enum of possible MicrosoftTunnelServer health status types</summary>
    public enum MicrosoftTunnelServerHealthStatus {
        /// <summary>Indicates that the health status of the server is unknown. This occurs when no health status has been reported, for example when the server is initialized, but has not yet been evaluated for its health.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Indicates that the health status of the server is healthy. This should be the normal operational health status.</summary>
        [EnumMember(Value = "healthy")]
        Healthy,
        /// <summary>Indicates that the health status of the server is unhealthy. This is normally a transient condition that will last up to 5 minutes. If the server cannot be remediated while reporting unhealthy state, the health state will change to &apos;warning&apos;. If it can be remediated, the health state will return to &apos;healthy&apos;.</summary>
        [EnumMember(Value = "unhealthy")]
        Unhealthy,
        /// <summary>Indicates a warning based on the Tunnel Gateway server&apos;s CPU usage, memory usage, latency, TLS certificate, version</summary>
        [EnumMember(Value = "warning")]
        Warning,
        /// <summary>Indicates the server state is offline</summary>
        [EnumMember(Value = "offline")]
        Offline,
        /// <summary>Indicates the upgrade in progress during the upgrade cycle of when Intune begins upgrading servers, one server at a time</summary>
        [EnumMember(Value = "upgradeInProgress")]
        UpgradeInProgress,
        /// <summary>Indicates the failure of the upgrade during the upgrade cycle of when Intune begins upgrading servers, one server at a time</summary>
        [EnumMember(Value = "upgradeFailed")]
        UpgradeFailed,
        /// <summary>Evolvable enumeration sentinel value. Do not use enums.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
