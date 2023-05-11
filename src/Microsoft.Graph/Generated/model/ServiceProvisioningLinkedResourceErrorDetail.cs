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
    /// The type ServiceProvisioningLinkedResourceErrorDetail.
    /// </summary>
    public partial class ServiceProvisioningLinkedResourceErrorDetail : ServiceProvisioningResourceErrorDetail
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceProvisioningLinkedResourceErrorDetail"/> class.
        /// </summary>
        public ServiceProvisioningLinkedResourceErrorDetail()
        {
            this.ODataType = "microsoft.graph.serviceProvisioningLinkedResourceErrorDetail";
        }

        /// <summary>
        /// Gets or sets propertyName.
        /// </summary>
        [JsonPropertyName("propertyName")]
        public string PropertyName { get; set; }
    
        /// <summary>
        /// Gets or sets target.
        /// </summary>
        [JsonPropertyName("target")]
        public string Target { get; set; }
    
    }
}
