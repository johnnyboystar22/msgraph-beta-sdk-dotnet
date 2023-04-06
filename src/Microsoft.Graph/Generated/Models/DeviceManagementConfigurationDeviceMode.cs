using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Describes applicability for the mode the device is in</summary>
    public enum DeviceManagementConfigurationDeviceMode {
        /// <summary>No Device Mode specified</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Device must be in kiosk mode for this setting to apply</summary>
        [EnumMember(Value = "kiosk")]
        Kiosk,
    }
}
