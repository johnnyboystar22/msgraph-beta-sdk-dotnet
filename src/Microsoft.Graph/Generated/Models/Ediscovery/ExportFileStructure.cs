using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Ediscovery {
    public enum ExportFileStructure {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "directory")]
        Directory,
        [EnumMember(Value = "pst")]
        Pst,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
