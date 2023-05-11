// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type HostRequest.
    /// </summary>
    public partial class HostRequest : Microsoft.Graph.BaseRequest, IHostRequest
    {
        /// <summary>
        /// Constructs a new HostRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public HostRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Host using POST.
        /// </summary>
        /// <param name="hostToCreate">The Host to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Host.</returns>
        public async System.Threading.Tasks.Task<Host> CreateAsync(Host hostToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<Host>(hostToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified Host using POST and returns a <see cref="GraphResponse{Host}"/> object.
        /// </summary>
        /// <param name="hostToCreate">The Host to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Host}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Host>> CreateResponseAsync(Host hostToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<Host>(hostToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified Host.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<Host>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Host and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified Host.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Host.</returns>
        public async System.Threading.Tasks.Task<Host> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<Host>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified Host and returns a <see cref="GraphResponse{Host}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Host}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Host>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<Host>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Host using PATCH.
        /// </summary>
        /// <param name="hostToUpdate">The Host to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Host.</returns>
        public async System.Threading.Tasks.Task<Host> UpdateAsync(Host hostToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<Host>(hostToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Host using PATCH and returns a <see cref="GraphResponse{Host}"/> object.
        /// </summary>
        /// <param name="hostToUpdate">The Host to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Host}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Host>> UpdateResponseAsync(Host hostToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<Host>(hostToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Host using PUT.
        /// </summary>
        /// <param name="hostToUpdate">The Host object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<Host> PutAsync(Host hostToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<Host>(hostToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Host using PUT and returns a <see cref="GraphResponse{Host}"/> object.
        /// </summary>
        /// <param name="hostToUpdate">The Host object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{Host}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Host>> PutResponseAsync(Host hostToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<Host>(hostToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IHostRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IHostRequest Expand(Expression<Func<Host, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IHostRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IHostRequest Select(Expression<Func<Host, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="hostToInitialize">The <see cref="Host"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Host hostToInitialize)
        {

            if (hostToInitialize != null)
            {
                if (hostToInitialize.Components != null && hostToInitialize.Components.CurrentPage != null)
                {
                    hostToInitialize.Components.InitializeNextPageRequest(this.Client, hostToInitialize.ComponentsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    hostToInitialize.Components.AdditionalData = hostToInitialize.AdditionalData;
                }
                if (hostToInitialize.Cookies != null && hostToInitialize.Cookies.CurrentPage != null)
                {
                    hostToInitialize.Cookies.InitializeNextPageRequest(this.Client, hostToInitialize.CookiesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    hostToInitialize.Cookies.AdditionalData = hostToInitialize.AdditionalData;
                }
                if (hostToInitialize.PassiveDns != null && hostToInitialize.PassiveDns.CurrentPage != null)
                {
                    hostToInitialize.PassiveDns.InitializeNextPageRequest(this.Client, hostToInitialize.PassiveDnsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    hostToInitialize.PassiveDns.AdditionalData = hostToInitialize.AdditionalData;
                }
                if (hostToInitialize.PassiveDnsReverse != null && hostToInitialize.PassiveDnsReverse.CurrentPage != null)
                {
                    hostToInitialize.PassiveDnsReverse.InitializeNextPageRequest(this.Client, hostToInitialize.PassiveDnsReverseNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    hostToInitialize.PassiveDnsReverse.AdditionalData = hostToInitialize.AdditionalData;
                }
                if (hostToInitialize.Trackers != null && hostToInitialize.Trackers.CurrentPage != null)
                {
                    hostToInitialize.Trackers.InitializeNextPageRequest(this.Client, hostToInitialize.TrackersNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    hostToInitialize.Trackers.AdditionalData = hostToInitialize.AdditionalData;
                }

            }


        }
    }
}
