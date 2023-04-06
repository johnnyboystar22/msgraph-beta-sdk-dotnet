using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Mobile device management authority.</summary>
    public enum MdmAuthority {
        /// <summary>Unknown</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Intune</summary>
        [EnumMember(Value = "intune")]
        Intune,
        /// <summary>SCCM</summary>
        [EnumMember(Value = "sccm")]
        Sccm,
        /// <summary>Office365</summary>
        [EnumMember(Value = "office365")]
        Office365,
    }
}
