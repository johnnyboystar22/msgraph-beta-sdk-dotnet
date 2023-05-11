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
    /// The type Device Management Configuration Choice Setting Definition.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DeviceManagementConfigurationChoiceSettingDefinition>))]
    public partial class DeviceManagementConfigurationChoiceSettingDefinition : DeviceManagementConfigurationSettingDefinition
    {
    
        ///<summary>
        /// The DeviceManagementConfigurationChoiceSettingDefinition constructor
        ///</summary>
        public DeviceManagementConfigurationChoiceSettingDefinition()
        {
            this.ODataType = "microsoft.graph.deviceManagementConfigurationChoiceSettingDefinition";
        }

        /// <summary>
        /// Gets or sets default option id.
        /// Default option for the choice setting.
        /// </summary>
        [JsonPropertyName("defaultOptionId")]
        public string DefaultOptionId { get; set; }
    
        /// <summary>
        /// Gets or sets options.
        /// Options for the setting that can be selected.
        /// </summary>
        [JsonPropertyName("options")]
        public IEnumerable<DeviceManagementConfigurationOptionDefinition> Options { get; set; }
    
    }
}

