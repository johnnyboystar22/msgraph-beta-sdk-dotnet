// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph.SecurityNamespace
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum DetectionSource.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DetectionSource
    {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// Microsoft Defender For Endpoint
        /// </summary>
        MicrosoftDefenderForEndpoint = 1,
	
        /// <summary>
        /// Antivirus
        /// </summary>
        Antivirus = 2,
	
        /// <summary>
        /// Smart Screen
        /// </summary>
        SmartScreen = 4,
	
        /// <summary>
        /// Custom Ti
        /// </summary>
        CustomTi = 8,
	
        /// <summary>
        /// Microsoft Defender For Office365
        /// </summary>
        MicrosoftDefenderForOffice365 = 512,
	
        /// <summary>
        /// Automated Investigation
        /// </summary>
        AutomatedInvestigation = 1024,
	
        /// <summary>
        /// Microsoft Threat Experts
        /// </summary>
        MicrosoftThreatExperts = 2048,
	
        /// <summary>
        /// Custom Detection
        /// </summary>
        CustomDetection = 4096,
	
        /// <summary>
        /// Microsoft Defender For Identity
        /// </summary>
        MicrosoftDefenderForIdentity = 8192,
	
        /// <summary>
        /// Cloud App Security
        /// </summary>
        CloudAppSecurity = 16384,
	
        /// <summary>
        /// Microsoft365Defender
        /// </summary>
        Microsoft365Defender = 32768,
	
        /// <summary>
        /// Azure Ad Identity Protection
        /// </summary>
        AzureAdIdentityProtection = 65536,
	
        /// <summary>
        /// Manual
        /// </summary>
        Manual = 262144,
	
        /// <summary>
        /// Microsoft Data Loss Prevention
        /// </summary>
        MicrosoftDataLossPrevention = 524288,
	
        /// <summary>
        /// App Governance Policy
        /// </summary>
        AppGovernancePolicy = 1048576,
	
        /// <summary>
        /// App Governance Detection
        /// </summary>
        AppGovernanceDetection = 2097152,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 4194303,
	
        /// <summary>
        /// Microsoft Defender For Cloud
        /// </summary>
        MicrosoftDefenderForCloud = 4194304,
	
    }
}
