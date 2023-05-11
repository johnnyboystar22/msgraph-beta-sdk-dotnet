// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph.IndustryData
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IIndustryDataRootDataConnectorsCollectionRequestBuilder.
    /// </summary>
    public partial interface IIndustryDataRootDataConnectorsCollectionRequestBuilder : Microsoft.Graph.IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IIndustryDataRootDataConnectorsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IIndustryDataRootDataConnectorsCollectionRequest Request(IEnumerable<Microsoft.Graph.Option> options);

        /// <summary>
        /// Gets an <see cref="IIndustryDataConnectorRequestBuilder"/> for the specified IndustryDataConnector.
        /// </summary>
        /// <param name="id">The ID for the IndustryDataConnector.</param>
        /// <returns>The <see cref="IIndustryDataConnectorRequestBuilder"/>.</returns>
        IIndustryDataConnectorRequestBuilder this[string id] { get; }

        
    }
}
