// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph.ExternalConnectors
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ExternalRequestBuilder.
    /// </summary>
    public partial class ExternalRequestBuilder : Microsoft.Graph.BaseRequestBuilder, IExternalRequestBuilder
    {

        /// <summary>
        /// Constructs a new ExternalRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public ExternalRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IExternalRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IExternalRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new ExternalRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for IndustryData.
        /// </summary>
        /// <returns>The <see cref="Microsoft.Graph.IndustryData.IIndustryDataRootRequestBuilder"/>.</returns>
        public Microsoft.Graph.IndustryData.IIndustryDataRootRequestBuilder IndustryData
        {
            get
            {
                return new Microsoft.Graph.IndustryData.IndustryDataRootRequestBuilder(this.AppendSegmentToRequestUrl("industryData"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Connections.
        /// </summary>
        /// <returns>The <see cref="IExternalConnectionsCollectionRequestBuilder"/>.</returns>
        public IExternalConnectionsCollectionRequestBuilder Connections
        {
            get
            {
                return new ExternalConnectionsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("connections"), this.Client);
            }
        }
    
    }
}
