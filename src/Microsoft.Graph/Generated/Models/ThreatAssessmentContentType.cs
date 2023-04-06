using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ThreatAssessmentContentType {
        [EnumMember(Value = "mail")]
        Mail,
        [EnumMember(Value = "url")]
        Url,
        [EnumMember(Value = "file")]
        File,
    }
}
