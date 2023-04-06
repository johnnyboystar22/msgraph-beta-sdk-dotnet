using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CloudPcOperatingSystem {
        [EnumMember(Value = "windows10")]
        Windows10,
        [EnumMember(Value = "windows11")]
        Windows11,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
