using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Windows 10 Device Mode type.</summary>
    public enum Windows10DeviceModeType {
        /// <summary>Standard Configuration</summary>
        [EnumMember(Value = "standardConfiguration")]
        StandardConfiguration,
        /// <summary>S Mode Configuration</summary>
        [EnumMember(Value = "sModeConfiguration")]
        SModeConfiguration,
    }
}
