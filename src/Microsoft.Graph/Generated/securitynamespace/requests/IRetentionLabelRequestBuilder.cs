// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IRetentionLabelRequestBuilder.
    /// </summary>
    public partial interface IRetentionLabelRequestBuilder : Microsoft.Graph.IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IRetentionLabelRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IRetentionLabelRequest Request(IEnumerable<Microsoft.Graph.Option> options);
    
        /// <summary>
        /// Gets the request builder for Descriptors.
        /// </summary>
        /// <returns>The <see cref="IFilePlanDescriptorRequestBuilder"/>.</returns>
        IFilePlanDescriptorRequestBuilder Descriptors { get; }

        /// <summary>
        /// Gets the request builder for DispositionReviewStages.
        /// </summary>
        /// <returns>The <see cref="IRetentionLabelDispositionReviewStagesCollectionRequestBuilder"/>.</returns>
        IRetentionLabelDispositionReviewStagesCollectionRequestBuilder DispositionReviewStages { get; }

        /// <summary>
        /// Gets the request builder for RetentionEventType.
        /// </summary>
        /// <returns>The <see cref="IRetentionEventTypeWithReferenceRequestBuilder"/>.</returns>
        IRetentionEventTypeWithReferenceRequestBuilder RetentionEventType { get; }
    
    }
}
