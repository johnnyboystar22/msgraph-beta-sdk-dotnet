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
    /// The type CustomExtensionCallbackConfiguration.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<CustomExtensionCallbackConfiguration>))]
    public partial class CustomExtensionCallbackConfiguration
    {

        ///<summary>
        /// The internal CustomExtensionCallbackConfiguration constructor
        ///</summary>
        protected internal CustomExtensionCallbackConfiguration()
        {
            // Don't allow initialization of abstract complex types
        }

        /// <summary>
        /// Gets or sets timeoutDuration.
        /// The maximum duration in ISO 8601 format that Azure AD will wait for a resume action for the callout it sent to the logic app. The valid range for custom extensions in lifecycle workflows is five minutes to three hours. The valid range for custom extensions in entitlement management is between 5 minutes and 14 days. For example, PT3H refers to three hours, P3D refers to three days, PT10M refers to ten minutes.
        /// </summary>
        [JsonPropertyName("timeoutDuration")]
        public Duration TimeoutDuration { get; set; }
    
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
