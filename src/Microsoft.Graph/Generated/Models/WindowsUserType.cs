using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum WindowsUserType {
        [EnumMember(Value = "administrator")]
        Administrator,
        [EnumMember(Value = "standard")]
        Standard,
    }
}
