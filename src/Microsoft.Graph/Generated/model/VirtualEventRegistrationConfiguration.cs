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
    /// The type Virtual Event Registration Configuration.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<VirtualEventRegistrationConfiguration>))]
    public partial class VirtualEventRegistrationConfiguration : Entity
    {
    
        /// <summary>
        /// Gets or sets capacity.
        /// </summary>
        [JsonPropertyName("capacity")]
        public Int32? Capacity { get; set; }
    
        /// <summary>
        /// Gets or sets registration web url.
        /// </summary>
        [JsonPropertyName("registrationWebUrl")]
        public string RegistrationWebUrl { get; set; }
    
        /// <summary>
        /// Gets or sets questions.
        /// </summary>
        [JsonPropertyName("questions")]
        public IVirtualEventRegistrationConfigurationQuestionsCollectionWithReferencesPage Questions { get; set; }

        /// <summary>
        /// Gets or sets questionsNextLink.
        /// </summary>
        [JsonPropertyName("questions@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string QuestionsNextLink { get; set; }
    
    }
}

