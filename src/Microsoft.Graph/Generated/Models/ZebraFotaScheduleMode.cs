using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Represents various schedule modes for Zebra FOTA deployment.</summary>
    public enum ZebraFotaScheduleMode {
        /// <summary>Instructs the device to install the update as soon as it is received.</summary>
        [EnumMember(Value = "installNow")]
        InstallNow,
        /// <summary>Schedule an update to be installed at a specified date and time.</summary>
        [EnumMember(Value = "scheduled")]
        Scheduled,
        /// <summary>Unknown future enum value.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
