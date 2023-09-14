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
    /// The type On User Create Start Listener.
    /// </summary>
    public partial class OnUserCreateStartListener : AuthenticationEventListener
    {
    
        ///<summary>
        /// The OnUserCreateStartListener constructor
        ///</summary>
        public OnUserCreateStartListener()
        {
            this.ODataType = "microsoft.graph.onUserCreateStartListener";
        }

        /// <summary>
        /// Gets or sets handler.
        /// Required. Configuration for what to invoke if the event resolves to this listener. This lets us define potential handler configurations per-event.
        /// </summary>
        [JsonPropertyName("handler")]
        public OnUserCreateStartHandler Handler { get; set; }
    
    }
}

