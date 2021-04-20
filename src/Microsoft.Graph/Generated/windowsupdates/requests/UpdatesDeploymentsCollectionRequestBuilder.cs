// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph.WindowsUpdates
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type UpdatesDeploymentsCollectionRequestBuilder.
    /// </summary>
    public partial class UpdatesDeploymentsCollectionRequestBuilder : Microsoft.Graph.BaseRequestBuilder, IUpdatesDeploymentsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new UpdatesDeploymentsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public UpdatesDeploymentsCollectionRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IUpdatesDeploymentsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IUpdatesDeploymentsCollectionRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new UpdatesDeploymentsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDeploymentRequestBuilder"/> for the specified UpdatesDeployment.
        /// </summary>
        /// <param name="id">The ID for the UpdatesDeployment.</param>
        /// <returns>The <see cref="IDeploymentRequestBuilder"/>.</returns>
        public IDeploymentRequestBuilder this[string id]
        {
            get
            {
                return new DeploymentRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
