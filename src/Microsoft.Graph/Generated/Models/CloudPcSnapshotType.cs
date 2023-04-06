using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CloudPcSnapshotType {
        [EnumMember(Value = "automatic")]
        Automatic,
        [EnumMember(Value = "manual")]
        Manual,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
