// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.Networkaccess
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Forwarding Profile.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<ForwardingProfile>))]
    public partial class ForwardingProfile : Profile
    {
    
        ///<summary>
        /// The ForwardingProfile constructor
        ///</summary>
        public ForwardingProfile()
        {
            this.ODataType = "microsoft.graph.networkaccess.forwardingProfile";
        }

        /// <summary>
        /// Gets or sets associations.
        /// Specifies the users, groups, devices, and branch locations whose traffic is associated with the given traffic forwarding profile.
        /// </summary>
        [JsonPropertyName("associations")]
        public IEnumerable<Association> Associations { get; set; }
    
        /// <summary>
        /// Gets or sets priority.
        /// Profile priority.
        /// </summary>
        [JsonPropertyName("priority")]
        public Int32? Priority { get; set; }
    
        /// <summary>
        /// Gets or sets traffic forwarding type.
        /// Profile traffic type. The possible values are: m365, internet, private.
        /// </summary>
        [JsonPropertyName("trafficForwardingType")]
        public TrafficForwardingType? TrafficForwardingType { get; set; }
    
    }
}

