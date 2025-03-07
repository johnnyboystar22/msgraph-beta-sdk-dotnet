// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>State of remote assistance for the account</summary>
    public enum RemoteAssistanceState
    {
        /// <summary>Remote assistance is disabled for the account. With this value, Quick Assist remote assistance sessions are not allowed for the account.</summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>Remote assistance is enabled for the account. With this value, enterprise Quick Assist remote assistance features are provided.</summary>
        [EnumMember(Value = "enabled")]
        Enabled,
    }
}
