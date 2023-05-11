// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph.ExternalConnectors
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IExternalRequestBuilder.
    /// </summary>
    public partial interface IExternalRequestBuilder : Microsoft.Graph.IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IExternalRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IExternalRequest Request(IEnumerable<Microsoft.Graph.Option> options);
    
        /// <summary>
        /// Gets the request builder for IndustryData.
        /// </summary>
        /// <returns>The <see cref="Microsoft.Graph.IndustryData.IIndustryDataRootRequestBuilder"/>.</returns>
        Microsoft.Graph.IndustryData.IIndustryDataRootRequestBuilder IndustryData { get; }

        /// <summary>
        /// Gets the request builder for Connections.
        /// </summary>
        /// <returns>The <see cref="IExternalConnectionsCollectionRequestBuilder"/>.</returns>
        IExternalConnectionsCollectionRequestBuilder Connections { get; }
    
    }
}
