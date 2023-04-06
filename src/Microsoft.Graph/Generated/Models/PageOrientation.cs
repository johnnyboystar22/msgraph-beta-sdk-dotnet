using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum PageOrientation {
        [EnumMember(Value = "horizontal")]
        Horizontal,
        [EnumMember(Value = "diagonal")]
        Diagonal,
    }
}
