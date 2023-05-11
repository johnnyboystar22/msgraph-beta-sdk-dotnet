// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ThreatIntelligenceVulnerabilitiesCollectionRequestBuilder.
    /// </summary>
    public partial class ThreatIntelligenceVulnerabilitiesCollectionRequestBuilder : Microsoft.Graph.BaseRequestBuilder, IThreatIntelligenceVulnerabilitiesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ThreatIntelligenceVulnerabilitiesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public ThreatIntelligenceVulnerabilitiesCollectionRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IThreatIntelligenceVulnerabilitiesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IThreatIntelligenceVulnerabilitiesCollectionRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new ThreatIntelligenceVulnerabilitiesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IVulnerabilityRequestBuilder"/> for the specified ThreatIntelligenceVulnerability.
        /// </summary>
        /// <param name="id">The ID for the ThreatIntelligenceVulnerability.</param>
        /// <returns>The <see cref="IVulnerabilityRequestBuilder"/>.</returns>
        public IVulnerabilityRequestBuilder this[string id]
        {
            get
            {
                return new VulnerabilityRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
