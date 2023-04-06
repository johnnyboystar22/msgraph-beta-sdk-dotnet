using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CloudAppSecuritySessionControlType {
        [EnumMember(Value = "mcasConfigured")]
        McasConfigured,
        [EnumMember(Value = "monitorOnly")]
        MonitorOnly,
        [EnumMember(Value = "blockDownloads")]
        BlockDownloads,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
