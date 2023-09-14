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
    /// The type MacOSIncludedApp.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<MacOSIncludedApp>))]
    public partial class MacOSIncludedApp
    {

        /// <summary>
        /// Gets or sets bundleId.
        /// The bundleId of the app. This maps to the CFBundleIdentifier in the app's bundle configuration.
        /// </summary>
        [JsonPropertyName("bundleId")]
        public string BundleId { get; set; }
    
        /// <summary>
        /// Gets or sets bundleVersion.
        /// The version of the app. This maps to the CFBundleShortVersion in the app's bundle configuration.
        /// </summary>
        [JsonPropertyName("bundleVersion")]
        public string BundleVersion { get; set; }
    
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
