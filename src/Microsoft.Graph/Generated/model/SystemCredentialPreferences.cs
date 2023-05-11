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
    /// The type SystemCredentialPreferences.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<SystemCredentialPreferences>))]
    public partial class SystemCredentialPreferences
    {

        /// <summary>
        /// Gets or sets excludeTargets.
        /// Users and groups excluded from the preferred authentication method experience of the system.
        /// </summary>
        [JsonPropertyName("excludeTargets")]
        public IEnumerable<ExcludeTarget> ExcludeTargets { get; set; }
    
        /// <summary>
        /// Gets or sets includeTargets.
        /// Users and groups included in the preferred authentication method experience of the system.
        /// </summary>
        [JsonPropertyName("includeTargets")]
        public IEnumerable<IncludeTarget> IncludeTargets { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// Indicates whether the feature is enabled or disabled. Possible values are: default, enabled, disabled, unknownFutureValue. The default value is used when the configuration hasn't been explicitly set, and uses the default behavior of Azure Active Directory for the setting. The default value is disabled.
        /// </summary>
        [JsonPropertyName("state")]
        public AdvancedConfigState? State { get; set; }
    
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
