// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type WhoisRecordHistoryCollectionReferencesRequestBuilder.
    /// </summary>
    public partial class WhoisRecordHistoryCollectionReferencesRequestBuilder : Microsoft.Graph.BaseRequestBuilder, IWhoisRecordHistoryCollectionReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new WhoisRecordHistoryCollectionReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public WhoisRecordHistoryCollectionReferencesRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IWhoisRecordHistoryCollectionReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IWhoisRecordHistoryCollectionReferencesRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new WhoisRecordHistoryCollectionReferencesRequest(this.RequestUrl, this.Client, options);
        }
    }
}
