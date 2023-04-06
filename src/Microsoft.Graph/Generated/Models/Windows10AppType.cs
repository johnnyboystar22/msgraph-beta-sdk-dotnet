using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Windows 10 Application type.</summary>
    public enum Windows10AppType {
        /// <summary>Desktop.</summary>
        [EnumMember(Value = "desktop")]
        Desktop,
        /// <summary>Universal.</summary>
        [EnumMember(Value = "universal")]
        Universal,
    }
}
