using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Possible values for the EdgeOpensWith setting.</summary>
    public enum EdgeOpenOptions {
        /// <summary>Not configured.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>StartPage.</summary>
        [EnumMember(Value = "startPage")]
        StartPage,
        /// <summary>NewTabPage.</summary>
        [EnumMember(Value = "newTabPage")]
        NewTabPage,
        /// <summary>PreviousPages.</summary>
        [EnumMember(Value = "previousPages")]
        PreviousPages,
        /// <summary>SpecificPages.</summary>
        [EnumMember(Value = "specificPages")]
        SpecificPages,
    }
}
