using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Authentication transform values for Windows10 VPN policies with IKEv2 connection type.</summary>
    public enum AuthenticationTransformConstant {
        /// <summary>MD596</summary>
        [EnumMember(Value = "md5_96")]
        Md5_96,
        /// <summary>SHA196</summary>
        [EnumMember(Value = "sha1_96")]
        Sha1_96,
        /// <summary>SHA256128</summary>
        [EnumMember(Value = "sha_256_128")]
        Sha_256_128,
        /// <summary>GCMAES128</summary>
        [EnumMember(Value = "aes128Gcm")]
        Aes128Gcm,
        /// <summary>GCMAES192</summary>
        [EnumMember(Value = "aes192Gcm")]
        Aes192Gcm,
        /// <summary>GCMAES256</summary>
        [EnumMember(Value = "aes256Gcm")]
        Aes256Gcm,
    }
}
