using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Possible values of the DmaGuardDeviceEnumerationPolicy.</summary>
    public enum DmaGuardDeviceEnumerationPolicyType {
        /// <summary>Default value. Devices with DMA remapping incompatible drivers will only be enumerated after the user unlocks the screen.</summary>
        [EnumMember(Value = "deviceDefault")]
        DeviceDefault,
        /// <summary>Devices with DMA remapping incompatible drivers will never be allowed to start and perform DMA at any time.</summary>
        [EnumMember(Value = "blockAll")]
        BlockAll,
        /// <summary>All external DMA capable PCIe devices will be enumerated at any time.</summary>
        [EnumMember(Value = "allowAll")]
        AllowAll,
    }
}
