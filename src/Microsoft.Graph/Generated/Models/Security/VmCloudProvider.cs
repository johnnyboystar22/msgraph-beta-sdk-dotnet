using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum VmCloudProvider {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "azure")]
        Azure,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
