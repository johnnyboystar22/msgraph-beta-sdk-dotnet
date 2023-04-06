using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ScreenSharingRole {
        [EnumMember(Value = "viewer")]
        Viewer,
        [EnumMember(Value = "sharer")]
        Sharer,
    }
}
