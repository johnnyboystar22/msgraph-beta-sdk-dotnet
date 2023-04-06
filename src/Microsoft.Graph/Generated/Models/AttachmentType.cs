using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum AttachmentType {
        [EnumMember(Value = "file")]
        File,
        [EnumMember(Value = "item")]
        Item,
        [EnumMember(Value = "reference")]
        Reference,
    }
}
