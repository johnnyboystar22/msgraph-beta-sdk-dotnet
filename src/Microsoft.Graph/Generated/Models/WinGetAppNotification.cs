using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Contains value for notification status.</summary>
    public enum WinGetAppNotification {
        /// <summary>Show all notifications.</summary>
        [EnumMember(Value = "showAll")]
        ShowAll,
        /// <summary>Only show restart notification and suppress other notifications.</summary>
        [EnumMember(Value = "showReboot")]
        ShowReboot,
        /// <summary>Hide all notifications.</summary>
        [EnumMember(Value = "hideAll")]
        HideAll,
        /// <summary>Unknown future value, reserved for future usage as expandable enum.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
