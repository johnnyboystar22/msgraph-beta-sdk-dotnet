using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Processor architecture</summary>
    public enum ManagedDeviceArchitecture {
        /// <summary>Unknown architecture</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>X86</summary>
        [EnumMember(Value = "x86")]
        X86,
        /// <summary>X64</summary>
        [EnumMember(Value = "x64")]
        X64,
        /// <summary>ARM</summary>
        [EnumMember(Value = "arm")]
        Arm,
        /// <summary>ARM64</summary>
        [EnumMember(Value = "arM64")]
        ArM64,
    }
}
