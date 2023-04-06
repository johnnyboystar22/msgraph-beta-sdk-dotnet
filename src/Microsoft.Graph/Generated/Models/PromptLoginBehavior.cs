using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum PromptLoginBehavior {
        [EnumMember(Value = "translateToFreshPasswordAuthentication")]
        TranslateToFreshPasswordAuthentication,
        [EnumMember(Value = "nativeSupport")]
        NativeSupport,
        [EnumMember(Value = "disabled")]
        Disabled,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
