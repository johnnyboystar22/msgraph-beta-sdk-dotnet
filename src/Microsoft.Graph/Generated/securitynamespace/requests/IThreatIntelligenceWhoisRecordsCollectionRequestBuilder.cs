// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IThreatIntelligenceWhoisRecordsCollectionRequestBuilder.
    /// </summary>
    public partial interface IThreatIntelligenceWhoisRecordsCollectionRequestBuilder : Microsoft.Graph.IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IThreatIntelligenceWhoisRecordsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IThreatIntelligenceWhoisRecordsCollectionRequest Request(IEnumerable<Microsoft.Graph.Option> options);

        /// <summary>
        /// Gets an <see cref="IWhoisRecordRequestBuilder"/> for the specified WhoisRecord.
        /// </summary>
        /// <param name="id">The ID for the WhoisRecord.</param>
        /// <returns>The <see cref="IWhoisRecordRequestBuilder"/>.</returns>
        IWhoisRecordRequestBuilder this[string id] { get; }

        
    }
}
