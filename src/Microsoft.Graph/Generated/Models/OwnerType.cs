using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Owner type of device.</summary>
    public enum OwnerType {
        /// <summary>Unknown.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Owned by company.</summary>
        [EnumMember(Value = "company")]
        Company,
        /// <summary>Owned by person.</summary>
        [EnumMember(Value = "personal")]
        Personal,
    }
}
