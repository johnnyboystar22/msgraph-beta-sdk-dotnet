using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Indicates the channel used to deploy the configuration profile. Available choices are DeviceChannel, UserChannel</summary>
    public enum AppleDeploymentChannel {
        /// <summary>Send payload down over Device Channel.</summary>
        [EnumMember(Value = "deviceChannel")]
        DeviceChannel,
        /// <summary>Send payload down over User Channel.</summary>
        [EnumMember(Value = "userChannel")]
        UserChannel,
    }
}
