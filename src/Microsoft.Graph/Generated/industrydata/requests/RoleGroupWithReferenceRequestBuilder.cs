// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityWithReferenceRequestBuilder.cs.tt

namespace Microsoft.Graph.IndustryData
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type RoleGroupWithReferenceRequestBuilder.
    /// </summary>
    public partial class RoleGroupWithReferenceRequestBuilder : Microsoft.Graph.BaseRequestBuilder, IRoleGroupWithReferenceRequestBuilder
    {

        /// <summary>
        /// Constructs a new RoleGroupWithReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public RoleGroupWithReferenceRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IRoleGroupWithReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IRoleGroupWithReferenceRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new RoleGroupWithReferenceRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets the request builder for the reference of the roleGroup.
        /// </summary>
        /// <returns>The <see cref="IRoleGroupReferenceRequestBuilder"/>.</returns>
        public IRoleGroupReferenceRequestBuilder Reference
        {
            get
            {
                return new RoleGroupReferenceRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
