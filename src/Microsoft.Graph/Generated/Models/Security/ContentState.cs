using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum ContentState {
        [EnumMember(Value = "rest")]
        Rest,
        [EnumMember(Value = "motion")]
        Motion,
        [EnumMember(Value = "use")]
        Use,
    }
}
