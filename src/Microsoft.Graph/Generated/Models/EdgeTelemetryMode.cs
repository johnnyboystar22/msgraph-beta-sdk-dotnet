using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Type of browsing data sent to Microsoft 365 analytics</summary>
    public enum EdgeTelemetryMode {
        /// <summary>Default – No telemetry data collected or sent</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Allow sending intranet history only: Only send browsing history data for intranet sites</summary>
        [EnumMember(Value = "intranet")]
        Intranet,
        /// <summary>Allow sending internet history only: Only send browsing history data for internet sites</summary>
        [EnumMember(Value = "internet")]
        Internet,
        /// <summary>Allow sending both intranet and internet history: Send browsing history data for intranet and internet sites</summary>
        [EnumMember(Value = "intranetAndInternet")]
        IntranetAndInternet,
    }
}
