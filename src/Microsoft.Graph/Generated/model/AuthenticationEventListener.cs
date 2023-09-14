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
    /// The type Authentication Event Listener.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AuthenticationEventListener>))]
    public partial class AuthenticationEventListener : Entity
    {
    
        ///<summary>
        /// The internal AuthenticationEventListener constructor
        ///</summary>
        protected internal AuthenticationEventListener()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets authentication events flow id.
        /// The identifier of the authenticationEventsFlow object.
        /// </summary>
        [JsonPropertyName("authenticationEventsFlowId")]
        public string AuthenticationEventsFlowId { get; set; }
    
        /// <summary>
        /// Gets or sets conditions.
        /// The conditions on which this authenticationEventListener should trigger.
        /// </summary>
        [JsonPropertyName("conditions")]
        public AuthenticationConditions Conditions { get; set; }
    
        /// <summary>
        /// Gets or sets priority.
        /// The priority of this handler. Between 0 (lower priority) and 1000 (higher priority).
        /// </summary>
        [JsonPropertyName("priority")]
        public Int32? Priority { get; set; }
    
    }
}

