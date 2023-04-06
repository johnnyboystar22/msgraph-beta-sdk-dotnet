using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum AuthenticationMethodState {
        [EnumMember(Value = "enabled")]
        Enabled,
        [EnumMember(Value = "disabled")]
        Disabled,
    }
}
