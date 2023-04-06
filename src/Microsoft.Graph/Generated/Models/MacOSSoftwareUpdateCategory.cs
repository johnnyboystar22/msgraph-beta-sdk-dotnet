using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>MacOS Software Update Category</summary>
    public enum MacOSSoftwareUpdateCategory {
        /// <summary>A critical update</summary>
        [EnumMember(Value = "critical")]
        Critical,
        /// <summary>A configuration data file update</summary>
        [EnumMember(Value = "configurationDataFile")]
        ConfigurationDataFile,
        /// <summary>A firmware update</summary>
        [EnumMember(Value = "firmware")]
        Firmware,
        /// <summary>All other update types</summary>
        [EnumMember(Value = "other")]
        Other,
    }
}
