using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public enum UpdateCategory {
        [EnumMember(Value = "feature")]
        Feature,
        [EnumMember(Value = "quality")]
        Quality,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "driver")]
        Driver,
    }
}
