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
    /// The type ConditionalAccessDevices.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ConditionalAccessDevices>))]
    public partial class ConditionalAccessDevices
    {

        /// <summary>
        /// Gets or sets deviceFilter.
        /// Filter that defines the dynamic-device-syntax rule to include/exclude devices. A filter can use device properties (such as extension attributes) to include/exclude them. Cannot be set if includeDevices or excludeDevices is set.
        /// </summary>
        [JsonPropertyName("deviceFilter")]
        public ConditionalAccessFilter DeviceFilter { get; set; }
    
        /// <summary>
        /// Gets or sets excludeDevices.
        /// States excluded from the scope of the policy. Possible values: Compliant, DomainJoined. Cannot be set if deviceFIlter is set.
        /// </summary>
        [JsonPropertyName("excludeDevices")]
        public IEnumerable<string> ExcludeDevices { get; set; }
    
        /// <summary>
        /// Gets or sets excludeDeviceStates.
        /// </summary>
        [JsonPropertyName("excludeDeviceStates")]
        public IEnumerable<string> ExcludeDeviceStates { get; set; }
    
        /// <summary>
        /// Gets or sets includeDevices.
        /// States in the scope of the policy. All is the only allowed value. Cannot be set if deviceFilter is set.
        /// </summary>
        [JsonPropertyName("includeDevices")]
        public IEnumerable<string> IncludeDevices { get; set; }
    
        /// <summary>
        /// Gets or sets includeDeviceStates.
        /// </summary>
        [JsonPropertyName("includeDeviceStates")]
        public IEnumerable<string> IncludeDeviceStates { get; set; }
    
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
