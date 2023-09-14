// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IWorkbookCommentRequestBuilder.
    /// </summary>
    public partial interface IWorkbookCommentRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IWorkbookCommentRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IWorkbookCommentRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Replies.
        /// </summary>
        /// <returns>The <see cref="IWorkbookCommentRepliesCollectionRequestBuilder"/>.</returns>
        IWorkbookCommentRepliesCollectionRequestBuilder Replies { get; }

        /// <summary>
        /// Gets the request builder for @Task.
        /// </summary>
        /// <returns>The <see cref="IWorkbookDocumentTaskRequestBuilder"/>.</returns>
        IWorkbookDocumentTaskRequestBuilder @Task { get; }
    
    }
}
