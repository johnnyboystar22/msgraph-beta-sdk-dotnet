using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Possible values for ApplicationGuardEnabledOptions</summary>
    public enum ApplicationGuardEnabledOptions {
        /// <summary>Not Configured</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Enabled For Edge</summary>
        [EnumMember(Value = "enabledForEdge")]
        EnabledForEdge,
        /// <summary>Enabled For Office</summary>
        [EnumMember(Value = "enabledForOffice")]
        EnabledForOffice,
        /// <summary>Enabled For Edge And Office</summary>
        [EnumMember(Value = "enabledForEdgeAndOffice")]
        EnabledForEdgeAndOffice,
    }
}
