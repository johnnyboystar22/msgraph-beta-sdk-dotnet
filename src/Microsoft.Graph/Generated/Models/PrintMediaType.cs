using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum PrintMediaType {
        [EnumMember(Value = "stationery")]
        Stationery,
        [EnumMember(Value = "transparency")]
        Transparency,
        [EnumMember(Value = "envelope")]
        Envelope,
        [EnumMember(Value = "envelopePlain")]
        EnvelopePlain,
        [EnumMember(Value = "continuous")]
        Continuous,
        [EnumMember(Value = "screen")]
        Screen,
        [EnumMember(Value = "screenPaged")]
        ScreenPaged,
        [EnumMember(Value = "continuousLong")]
        ContinuousLong,
        [EnumMember(Value = "continuousShort")]
        ContinuousShort,
        [EnumMember(Value = "envelopeWindow")]
        EnvelopeWindow,
        [EnumMember(Value = "multiPartForm")]
        MultiPartForm,
        [EnumMember(Value = "multiLayer")]
        MultiLayer,
        [EnumMember(Value = "labels")]
        Labels,
    }
}
