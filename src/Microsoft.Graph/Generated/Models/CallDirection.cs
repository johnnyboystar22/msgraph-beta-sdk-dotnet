using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CallDirection {
        [EnumMember(Value = "incoming")]
        Incoming,
        [EnumMember(Value = "outgoing")]
        Outgoing,
    }
}
