// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type CloudPcPartnerAgentInstallResult.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<CloudPcPartnerAgentInstallResult>))]
    public partial class CloudPcPartnerAgentInstallResult
    {

        /// <summary>
        /// Gets or sets installStatus.
        /// The status of a partner agent installation. Possible values are: installed, installFailed, installing, uninstalling, uninstallFailed and licensed. Read-Only.
        /// </summary>
        [JsonPropertyName("installStatus")]
        public CloudPcPartnerAgentInstallStatus? InstallStatus { get; set; }
    
        /// <summary>
        /// Gets or sets isThirdPartyPartner.
        /// Indicates if the partner agent is a third party. When 'TRUE', the agent is a third-party (non-Microsoft) agent.  When 'FALSE', the agent is a Microsoft agent or is not known.  The default value is 'FALSE'.
        /// </summary>
        [JsonPropertyName("isThirdPartyPartner")]
        public bool? IsThirdPartyPartner { get; set; }
    
        /// <summary>
        /// Gets or sets partnerAgentName.
        /// The name of the partner agent, whether first party or third party. Possible values for third-party partners are Citrix and VMware. Read-Only.
        /// </summary>
        [JsonPropertyName("partnerAgentName")]
        public CloudPcPartnerAgentName? PartnerAgentName { get; set; }
    
        /// <summary>
        /// Gets or sets retriable.
        /// Indicates if the partner agent is a third party. When 'TRUE', the agent is a third-party (non-Microsoft) agent. When 'FALSE', the agent is a Microsoft agent or is not known. The default value is 'FALSE'.
        /// </summary>
        [JsonPropertyName("retriable")]
        public bool? Retriable { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
