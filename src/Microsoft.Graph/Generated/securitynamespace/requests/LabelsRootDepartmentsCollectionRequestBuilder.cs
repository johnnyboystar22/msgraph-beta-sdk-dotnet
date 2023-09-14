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
    /// The type LabelsRootDepartmentsCollectionRequestBuilder.
    /// </summary>
    public partial class LabelsRootDepartmentsCollectionRequestBuilder : Microsoft.Graph.BaseRequestBuilder, ILabelsRootDepartmentsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new LabelsRootDepartmentsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public LabelsRootDepartmentsCollectionRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ILabelsRootDepartmentsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ILabelsRootDepartmentsCollectionRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new LabelsRootDepartmentsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDepartmentTemplateRequestBuilder"/> for the specified LabelsRootDepartmentTemplate.
        /// </summary>
        /// <param name="id">The ID for the LabelsRootDepartmentTemplate.</param>
        /// <returns>The <see cref="IDepartmentTemplateRequestBuilder"/>.</returns>
        public IDepartmentTemplateRequestBuilder this[string id]
        {
            get
            {
                return new DepartmentTemplateRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
