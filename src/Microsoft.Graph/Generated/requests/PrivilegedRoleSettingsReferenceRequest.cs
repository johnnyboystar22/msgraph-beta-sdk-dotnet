// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The type PrivilegedRoleSettingsReferenceRequest.
    /// </summary>
    public partial class PrivilegedRoleSettingsReferenceRequest : BaseRequest, IPrivilegedRoleSettingsReferenceRequest
    {
        /// <summary>
        /// Constructs a new PrivilegedRoleSettingsReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public PrivilegedRoleSettingsReferenceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Deletes the specified PrivilegedRoleSettings reference.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<PrivilegedRoleSettings>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified PrivilegedRoleSettings reference and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Puts the specified PrivilegedRoleSettings reference.
        /// </summary>
        /// <param name="id">The PrivilegedRoleSettings reference to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task PutAsync(string id, CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.PUT;
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            var referenceRequestBody = new ReferenceRequestBody()
            {
                ODataId = string.Format(@"{0}/users/{1}", this.Client.BaseUrl, id)
            };
            return this.SendAsync(referenceRequestBody, cancellationToken);
        }

        /// <summary>
        /// Puts the specified PrivilegedRoleSettings reference and returns <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="id">The PrivilegedRoleSettings reference to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse> PutResponseAsync(string id, CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.PUT;
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            var referenceRequestBody = new ReferenceRequestBody()
            {
                ODataId = string.Format(@"{0}/users/{1}", this.Client.BaseUrl, id)
            };
            return this.SendAsyncWithGraphResponse(referenceRequestBody, cancellationToken);
        }
    }
}
