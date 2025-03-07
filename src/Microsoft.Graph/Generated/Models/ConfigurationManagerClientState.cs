// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Configuration manager client state</summary>
    public enum ConfigurationManagerClientState
    {
        /// <summary>Configuration manager agent is older than 1806 or not installed or this device has not checked into Intune for over 30 days.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>The configuration manager agent is installed but may not be showing up in the configuration manager console yet. Wait a few hours for it to refresh.</summary>
        [EnumMember(Value = "installed")]
        Installed,
        /// <summary>This device was able to check in with the configuration manager service successfully.</summary>
        [EnumMember(Value = "healthy")]
        Healthy,
        /// <summary>The configuration manager agent failed to install.</summary>
        [EnumMember(Value = "installFailed")]
        InstallFailed,
        /// <summary>The update from version x to version y of the configuration manager agent failed. </summary>
        [EnumMember(Value = "updateFailed")]
        UpdateFailed,
        /// <summary>The configuration manager agent was able to reach the configuration manager service in the past but is now no longer able to. </summary>
        [EnumMember(Value = "communicationError")]
        CommunicationError,
    }
}
