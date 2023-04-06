using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum PrintOrientation {
        [EnumMember(Value = "portrait")]
        Portrait,
        [EnumMember(Value = "landscape")]
        Landscape,
        [EnumMember(Value = "reverseLandscape")]
        ReverseLandscape,
        [EnumMember(Value = "reversePortrait")]
        ReversePortrait,
    }
}
