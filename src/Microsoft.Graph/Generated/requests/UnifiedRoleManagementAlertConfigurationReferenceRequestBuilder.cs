// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityReferenceRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type UnifiedRoleManagementAlertConfigurationReferenceRequestBuilder.
    /// </summary>
    public partial class UnifiedRoleManagementAlertConfigurationReferenceRequestBuilder : BaseRequestBuilder, IUnifiedRoleManagementAlertConfigurationReferenceRequestBuilder
    {
        /// <summary>
        /// Constructs a new UnifiedRoleManagementAlertConfigurationReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public UnifiedRoleManagementAlertConfigurationReferenceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IUnifiedRoleManagementAlertConfigurationReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IUnifiedRoleManagementAlertConfigurationReferenceRequest Request(IEnumerable<Option> options)
        {
            return new UnifiedRoleManagementAlertConfigurationReferenceRequest(this.RequestUrl, this.Client, options);
        }
    }
}
