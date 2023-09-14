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
    /// The type TodoSettings.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<TodoSettings>))]
    public partial class TodoSettings
    {

        /// <summary>
        /// Gets or sets isExternalJoinEnabled.
        /// Controls whether users can join lists from users external to your organization.
        /// </summary>
        [JsonPropertyName("isExternalJoinEnabled")]
        public bool? IsExternalJoinEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets isExternalShareEnabled.
        /// Controls whether users can share lists with external users.
        /// </summary>
        [JsonPropertyName("isExternalShareEnabled")]
        public bool? IsExternalShareEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets isPushNotificationEnabled.
        /// Controls whether push notifications are enabled for your users.
        /// </summary>
        [JsonPropertyName("isPushNotificationEnabled")]
        public bool? IsPushNotificationEnabled { get; set; }
    
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
