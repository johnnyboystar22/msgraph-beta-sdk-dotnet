// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityReferenceRequestBuilder.cs.tt

namespace Microsoft.Graph.IndustryData
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IReferenceDefinitionReferenceRequestBuilder.
    /// </summary>
    public partial interface IReferenceDefinitionReferenceRequestBuilder : Microsoft.Graph.IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IReferenceDefinitionReferenceRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IReferenceDefinitionReferenceRequest Request(IEnumerable<Microsoft.Graph.Option> options);
    }
}
