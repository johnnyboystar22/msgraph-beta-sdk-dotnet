using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Edge kiosk type</summary>
    public enum WindowsEdgeKioskType {
        /// <summary>public-browsing</summary>
        [EnumMember(Value = "publicBrowsing")]
        PublicBrowsing,
        /// <summary>fullscreen</summary>
        [EnumMember(Value = "fullScreen")]
        FullScreen,
    }
}
