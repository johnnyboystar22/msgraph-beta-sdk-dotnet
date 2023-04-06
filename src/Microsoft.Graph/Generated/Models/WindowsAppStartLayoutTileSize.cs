using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The tile size of Windows app in the start layout.</summary>
    public enum WindowsAppStartLayoutTileSize {
        /// <summary>Hidden.</summary>
        [EnumMember(Value = "hidden")]
        Hidden,
        /// <summary>Small 1x1.</summary>
        [EnumMember(Value = "small")]
        Small,
        /// <summary>Medium 2x2.</summary>
        [EnumMember(Value = "medium")]
        Medium,
        /// <summary>Wide 4x2.</summary>
        [EnumMember(Value = "wide")]
        Wide,
        /// <summary>Large 4x4.</summary>
        [EnumMember(Value = "large")]
        Large,
    }
}
