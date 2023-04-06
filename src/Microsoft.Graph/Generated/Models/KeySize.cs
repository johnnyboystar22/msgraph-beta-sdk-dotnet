using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Key Size Options.</summary>
    public enum KeySize {
        /// <summary>1024 Bits.</summary>
        [EnumMember(Value = "size1024")]
        Size1024,
        /// <summary>2048 Bits.</summary>
        [EnumMember(Value = "size2048")]
        Size2048,
        /// <summary>4096 Bits.</summary>
        [EnumMember(Value = "size4096")]
        Size4096,
    }
}
