using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum SigninFrequencyType {
        [EnumMember(Value = "days")]
        Days,
        [EnumMember(Value = "hours")]
        Hours,
    }
}
