using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum Modality {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "audio")]
        Audio,
        [EnumMember(Value = "video")]
        Video,
        [EnumMember(Value = "videoBasedScreenSharing")]
        VideoBasedScreenSharing,
        [EnumMember(Value = "data")]
        Data,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
