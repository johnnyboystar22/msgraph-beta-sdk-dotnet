using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum OnenoteUserRole {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Owner")]
        Owner,
        [EnumMember(Value = "Contributor")]
        Contributor,
        [EnumMember(Value = "Reader")]
        Reader,
    }
}
