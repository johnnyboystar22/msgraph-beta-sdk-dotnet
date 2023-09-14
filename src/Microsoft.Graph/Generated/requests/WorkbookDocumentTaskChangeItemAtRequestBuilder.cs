// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookDocumentTaskChangeItemAtRequestBuilder.
    /// </summary>
    public partial class WorkbookDocumentTaskChangeItemAtRequestBuilder : BaseFunctionMethodRequestBuilder<IWorkbookDocumentTaskChangeItemAtRequest>, IWorkbookDocumentTaskChangeItemAtRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookDocumentTaskChangeItemAtRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="index">A index parameter for the OData method call.</param>
        public WorkbookDocumentTaskChangeItemAtRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Int32 index)
            : base(requestUrl, client)
        {
            this.SetParameter("index", index, false);
            this.SetFunctionParameters();
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookDocumentTaskChangeItemAtRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookDocumentTaskChangeItemAtRequest(functionUrl, this.Client, options);

            return request;
        }
        /// <summary>
        /// Gets the request builder for WorkbookDocumentTaskChangeCountRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookDocumentTaskChangeCountRequestBuilder"/>.</returns>
        public IWorkbookDocumentTaskChangeCountRequestBuilder Count()
        {
            return new WorkbookDocumentTaskChangeCountRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.count"),
                this.Client);
        }
        /// <summary>
        /// Gets the request builder for WorkbookDocumentTaskChangeItemAtRequestBuilder.
        /// </summary>
        /// <param name="index">A index parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookDocumentTaskChangeItemAtRequestBuilder"/>.</returns>
        public IWorkbookDocumentTaskChangeItemAtRequestBuilder ItemAt(
            Int32 index)
        {
            return new WorkbookDocumentTaskChangeItemAtRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.itemAt"),
                this.Client,
                index);
        }
    }
}
