using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Possible values for monitoring file activity.</summary>
    public enum DefenderRealtimeScanDirection {
        /// <summary>0 (default) – Monitor all files(bi-directional)</summary>
        [EnumMember(Value = "monitorAllFiles")]
        MonitorAllFiles,
        /// <summary>Monitor incoming files only.</summary>
        [EnumMember(Value = "monitorIncomingFilesOnly")]
        MonitorIncomingFilesOnly,
        /// <summary>Monitor outgoing files only.</summary>
        [EnumMember(Value = "monitorOutgoingFilesOnly")]
        MonitorOutgoingFilesOnly,
    }
}
