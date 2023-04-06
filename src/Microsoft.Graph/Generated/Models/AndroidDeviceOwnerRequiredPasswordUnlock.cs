using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>An enum representing possible values for required password unlock.</summary>
    public enum AndroidDeviceOwnerRequiredPasswordUnlock {
        /// <summary>Timeout period before strong authentication is required is set to the device&apos;s default.</summary>
        [EnumMember(Value = "deviceDefault")]
        DeviceDefault,
        /// <summary>Timeout period before strong authentication is required is set to 24 hours.</summary>
        [EnumMember(Value = "daily")]
        Daily,
        /// <summary>Unknown future value (reserved, not used right now)</summary>
        [EnumMember(Value = "unkownFutureValue")]
        UnkownFutureValue,
    }
}
