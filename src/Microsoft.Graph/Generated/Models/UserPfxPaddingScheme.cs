using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Supported values for the padding scheme used by encryption provider.</summary>
    public enum UserPfxPaddingScheme {
        /// <summary>Unknown padding Scheme.</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Pkcs1 is no longer supported</summary>
        [EnumMember(Value = "pkcs1")]
        Pkcs1,
        /// <summary>OaepSha1 is no longer supported</summary>
        [EnumMember(Value = "oaepSha1")]
        OaepSha1,
        /// <summary>Use OAEP SHA-256 padding.</summary>
        [EnumMember(Value = "oaepSha256")]
        OaepSha256,
        /// <summary>Use OAEP SHA-384 padding.</summary>
        [EnumMember(Value = "oaepSha384")]
        OaepSha384,
        /// <summary>Use OAEP SHA-512 padding.</summary>
        [EnumMember(Value = "oaepSha512")]
        OaepSha512,
    }
}
