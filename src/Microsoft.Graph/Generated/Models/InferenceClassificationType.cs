using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum InferenceClassificationType {
        [EnumMember(Value = "focused")]
        Focused,
        [EnumMember(Value = "other")]
        Other,
    }
}
