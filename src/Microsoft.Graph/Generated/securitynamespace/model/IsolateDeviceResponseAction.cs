// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type IsolateDeviceResponseAction.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<IsolateDeviceResponseAction>))]
    public partial class IsolateDeviceResponseAction : ResponseAction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IsolateDeviceResponseAction"/> class.
        /// </summary>
        public IsolateDeviceResponseAction()
        {
            this.ODataType = "microsoft.graph.security.isolateDeviceResponseAction";
        }

        /// <summary>
        /// Gets or sets identifier.
        /// </summary>
        [JsonPropertyName("identifier")]
        public DeviceIdEntityIdentifier? Identifier { get; set; }
    
        /// <summary>
        /// Gets or sets isolationType.
        /// </summary>
        [JsonPropertyName("isolationType")]
        public IsolationType? IsolationType { get; set; }
    
    }
}
