using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Possible values of the ConfigurationUsage list.</summary>
    public enum ConfigurationUsage {
        /// <summary>Disallowed.</summary>
        [EnumMember(Value = "blocked")]
        Blocked,
        /// <summary>Required.</summary>
        [EnumMember(Value = "required")]
        Required,
        /// <summary>Optional.</summary>
        [EnumMember(Value = "allowed")]
        Allowed,
        /// <summary>Not Configured.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
    }
}
