// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Device Management Configuration Simple Setting Collection Definition.
    /// </summary>
    public partial class DeviceManagementConfigurationSimpleSettingCollectionDefinition : DeviceManagementConfigurationSimpleSettingDefinition
    {
    
        ///<summary>
        /// The DeviceManagementConfigurationSimpleSettingCollectionDefinition constructor
        ///</summary>
        public DeviceManagementConfigurationSimpleSettingCollectionDefinition()
        {
            this.ODataType = "microsoft.graph.deviceManagementConfigurationSimpleSettingCollectionDefinition";
        }

        /// <summary>
        /// Gets or sets maximum count.
        /// Maximum number of simple settings in the collection
        /// </summary>
        [JsonPropertyName("maximumCount")]
        public Int32? MaximumCount { get; set; }
    
        /// <summary>
        /// Gets or sets minimum count.
        /// Minimum number of simple settings in the collection
        /// </summary>
        [JsonPropertyName("minimumCount")]
        public Int32? MinimumCount { get; set; }
    
    }
}

