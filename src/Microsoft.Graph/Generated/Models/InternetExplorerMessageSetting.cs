using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>What message will be displayed by Edge before switching to Internet Explorer.</summary>
    public enum InternetExplorerMessageSetting {
        /// <summary>Not configured.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Disabled.</summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>Enabled.</summary>
        [EnumMember(Value = "enabled")]
        Enabled,
        /// <summary>KeepGoing.</summary>
        [EnumMember(Value = "keepGoing")]
        KeepGoing,
    }
}
