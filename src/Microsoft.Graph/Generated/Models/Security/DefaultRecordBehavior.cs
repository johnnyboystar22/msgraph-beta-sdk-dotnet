using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum DefaultRecordBehavior {
        [EnumMember(Value = "startLocked")]
        StartLocked,
        [EnumMember(Value = "startUnlocked")]
        StartUnlocked,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
