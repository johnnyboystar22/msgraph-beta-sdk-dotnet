// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The type WorkbookDocumentTaskItemAtRequest.
    /// </summary>
    public partial class WorkbookDocumentTaskItemAtRequest : BaseRequest, IWorkbookDocumentTaskItemAtRequest
    {
        /// <summary>
        /// Constructs a new WorkbookDocumentTaskItemAtRequest.
        /// </summary>
        public WorkbookDocumentTaskItemAtRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Issues the GET request.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public System.Threading.Tasks.Task<WorkbookDocumentTask> GetAsync(
            CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsync<WorkbookDocumentTask>(null, cancellationToken);
        }

        /// <summary>
        /// Issues the GET request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        public System.Threading.Tasks.Task<GraphResponse<WorkbookDocumentTask>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<WorkbookDocumentTask>(null, cancellationToken);
        }


        /// <summary>
        /// Issues the PATCH request.
        /// </summary>
        /// <param name="workbookdocumenttask">The WorkbookDocumentTask object set with the properties to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public System.Threading.Tasks.Task<WorkbookDocumentTask> PatchAsync(WorkbookDocumentTask workbookdocumenttask,
            CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.PATCH;
            return this.SendAsync<WorkbookDocumentTask>(workbookdocumenttask, cancellationToken);
        }

        /// <summary>
        /// Issues the PATCH request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="workbookdocumenttask">The WorkbookDocumentTask object set with the properties to update.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        public System.Threading.Tasks.Task<GraphResponse<WorkbookDocumentTask>> PatchResponseAsync(WorkbookDocumentTask workbookdocumenttask, CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<WorkbookDocumentTask>(workbookdocumenttask, cancellationToken);
        }

        /// <summary>
        /// Issues the PUT request.
        /// </summary>
        /// <param name="workbookdocumenttask">The WorkbookDocumentTask object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public System.Threading.Tasks.Task<WorkbookDocumentTask> PutAsync(WorkbookDocumentTask workbookdocumenttask,
            CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.PUT;
            return this.SendAsync<WorkbookDocumentTask>(workbookdocumenttask, cancellationToken);
        }

        /// <summary>
        /// Issues the PUT request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="workbookdocumenttask">The WorkbookDocumentTask object set with the properties to update.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        public System.Threading.Tasks.Task<GraphResponse<WorkbookDocumentTask>> PutResponseAsync(WorkbookDocumentTask workbookdocumenttask, CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<WorkbookDocumentTask>(workbookdocumenttask, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookDocumentTaskItemAtRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookDocumentTaskItemAtRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }
    }
}
