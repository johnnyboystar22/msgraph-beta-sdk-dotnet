// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionReferencesRequest.cs.tt

namespace Microsoft.Graph.IdentityGovernanceNamespace
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The type WorkflowExecutionScopeCollectionReferencesRequest.
    /// </summary>
    public partial class WorkflowExecutionScopeCollectionReferencesRequest : Microsoft.Graph.BaseRequest, IWorkflowExecutionScopeCollectionReferencesRequest
    {
        /// <summary>
        /// Constructs a new WorkflowExecutionScopeCollectionReferencesRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WorkflowExecutionScopeCollectionReferencesRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }
        /// <summary>
        /// Adds the specified Microsoft.Graph.ReferenceRequestBody to the collection via POST.
        /// </summary>
        /// <param name="userProcessingResultReference">The Microsoft.Graph.ReferenceRequestBody to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task AddAsync(Microsoft.Graph.ReferenceRequestBody userProcessingResultReference, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;

            if (string.IsNullOrEmpty(userProcessingResultReference.ODataId))
            {
                throw new Microsoft.Graph.ServiceException(new Microsoft.Graph.Error { Code = "invalidRequest", Message = "ID is required to add a reference." });
            }

            return this.SendAsync(userProcessingResultReference, cancellationToken);
        }

        /// <summary>
        /// Adds the specified Microsoft.Graph.ReferenceRequestBody to the collection via POST and returns a <see cref="GraphResponse{Microsoft.Graph.ReferenceRequestBody}"/> object of the request.
        /// </summary>
        /// <param name="userProcessingResultReference">The Microsoft.Graph.ReferenceRequestBody to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> AddResponseAsync(Microsoft.Graph.ReferenceRequestBody userProcessingResultReference, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;

            if (string.IsNullOrEmpty(userProcessingResultReference.ODataId))
            {
                throw new Microsoft.Graph.ServiceException(new Microsoft.Graph.Error { Code = "invalidRequest", Message = "ID is required to add a reference." });
            }

            return this.SendAsyncWithGraphResponse(userProcessingResultReference, cancellationToken);
        }

    }
}
