// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Workforce Integration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkforceIntegration : ChangeTrackedEntity
    {
    
		///<summary>
		/// The WorkforceIntegration constructor
		///</summary>
        public WorkforceIntegration()
        {
            this.ODataType = "microsoft.graph.workforceIntegration";
        }
	
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets api version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "apiVersion", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ApiVersion { get; set; }
    
        /// <summary>
        /// Gets or sets encryption.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "encryption", Required = Newtonsoft.Json.Required.Default)]
        public WorkforceIntegrationEncryption Encryption { get; set; }
    
        /// <summary>
        /// Gets or sets is active.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isActive", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsActive { get; set; }
    
        /// <summary>
        /// Gets or sets url.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "url", Required = Newtonsoft.Json.Required.Default)]
        public string Url { get; set; }
    
        /// <summary>
        /// Gets or sets supports.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "supports", Required = Newtonsoft.Json.Required.Default)]
        public WorkforceIntegrationSupportedEntities? Supports { get; set; }
    
        /// <summary>
        /// Gets or sets supported entities.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "supportedEntities", Required = Newtonsoft.Json.Required.Default)]
        public WorkforceIntegrationSupportedEntities? SupportedEntities { get; set; }
    
    }
}

