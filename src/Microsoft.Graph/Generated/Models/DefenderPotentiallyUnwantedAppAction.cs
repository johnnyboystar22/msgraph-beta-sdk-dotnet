using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Defender’s action to take on detected Potentially Unwanted Application (PUA).</summary>
    public enum DefenderPotentiallyUnwantedAppAction {
        /// <summary>PUA Protection is off. Defender will not protect against potentially unwanted applications.</summary>
        [EnumMember(Value = "deviceDefault")]
        DeviceDefault,
        /// <summary>PUA Protection is on. Detected items are blocked. They will show in history along with other threats.</summary>
        [EnumMember(Value = "block")]
        Block,
        /// <summary>Audit mode. Defender will detect potentially unwanted applications, but take no actions. You can review information about applications Defender would have taken action against by searching for events created by Defender in the Event Viewer.</summary>
        [EnumMember(Value = "audit")]
        Audit,
    }
}
