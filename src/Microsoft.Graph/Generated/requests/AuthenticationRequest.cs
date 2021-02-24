// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type AuthenticationRequest.
    /// </summary>
    public partial class AuthenticationRequest : BaseRequest, IAuthenticationRequest
    {
        /// <summary>
        /// Constructs a new AuthenticationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AuthenticationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Authentication using POST.
        /// </summary>
        /// <param name="authenticationToCreate">The Authentication to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Authentication.</returns>
        public async System.Threading.Tasks.Task<Authentication> CreateAsync(Authentication authenticationToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.POST.ToString();
            var newEntity = await this.SendAsync<Authentication>(authenticationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified Authentication using POST and returns a <see cref="GraphResponse{Authentication}"/> object.
        /// </summary>
        /// <param name="authenticationToCreate">The Authentication to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Authentication}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Authentication>> CreateResponseAsync(Authentication authenticationToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.POST.ToString();
            return this.SendAsyncWithGraphResponse<Authentication>(authenticationToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified Authentication.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.DELETE.ToString();
            await this.SendAsync<Authentication>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Authentication and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.DELETE.ToString();
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified Authentication.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Authentication.</returns>
        public async System.Threading.Tasks.Task<Authentication> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.GET.ToString();
            var retrievedEntity = await this.SendAsync<Authentication>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified Authentication and returns a <see cref="GraphResponse{Authentication}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Authentication}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Authentication>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.GET.ToString();
            return this.SendAsyncWithGraphResponse<Authentication>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Authentication using PATCH.
        /// </summary>
        /// <param name="authenticationToUpdate">The Authentication to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Authentication.</returns>
        public async System.Threading.Tasks.Task<Authentication> UpdateAsync(Authentication authenticationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.PATCH.ToString();
            var updatedEntity = await this.SendAsync<Authentication>(authenticationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Authentication using PATCH and returns a <see cref="GraphResponse{Authentication}"/> object.
        /// </summary>
        /// <param name="authenticationToUpdate">The Authentication to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Authentication}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Authentication>> UpdateResponseAsync(Authentication authenticationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.PATCH.ToString();
            return this.SendAsyncWithGraphResponse<Authentication>(authenticationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAuthenticationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAuthenticationRequest Expand(Expression<Func<Authentication, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IAuthenticationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAuthenticationRequest Select(Expression<Func<Authentication, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="authenticationToInitialize">The <see cref="Authentication"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Authentication authenticationToInitialize)
        {

            if (authenticationToInitialize != null && authenticationToInitialize.AdditionalData != null)
            {

                if (authenticationToInitialize.EmailMethods != null && authenticationToInitialize.EmailMethods.CurrentPage != null)
                {
                    authenticationToInitialize.EmailMethods.AdditionalData = authenticationToInitialize.AdditionalData;

                    object nextPageLink;
                    authenticationToInitialize.AdditionalData.TryGetValue("emailMethods@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        authenticationToInitialize.EmailMethods.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (authenticationToInitialize.Fido2Methods != null && authenticationToInitialize.Fido2Methods.CurrentPage != null)
                {
                    authenticationToInitialize.Fido2Methods.AdditionalData = authenticationToInitialize.AdditionalData;

                    object nextPageLink;
                    authenticationToInitialize.AdditionalData.TryGetValue("fido2Methods@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        authenticationToInitialize.Fido2Methods.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (authenticationToInitialize.Methods != null && authenticationToInitialize.Methods.CurrentPage != null)
                {
                    authenticationToInitialize.Methods.AdditionalData = authenticationToInitialize.AdditionalData;

                    object nextPageLink;
                    authenticationToInitialize.AdditionalData.TryGetValue("methods@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        authenticationToInitialize.Methods.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (authenticationToInitialize.MicrosoftAuthenticatorMethods != null && authenticationToInitialize.MicrosoftAuthenticatorMethods.CurrentPage != null)
                {
                    authenticationToInitialize.MicrosoftAuthenticatorMethods.AdditionalData = authenticationToInitialize.AdditionalData;

                    object nextPageLink;
                    authenticationToInitialize.AdditionalData.TryGetValue("microsoftAuthenticatorMethods@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        authenticationToInitialize.MicrosoftAuthenticatorMethods.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (authenticationToInitialize.Operations != null && authenticationToInitialize.Operations.CurrentPage != null)
                {
                    authenticationToInitialize.Operations.AdditionalData = authenticationToInitialize.AdditionalData;

                    object nextPageLink;
                    authenticationToInitialize.AdditionalData.TryGetValue("operations@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        authenticationToInitialize.Operations.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (authenticationToInitialize.PasswordlessMicrosoftAuthenticatorMethods != null && authenticationToInitialize.PasswordlessMicrosoftAuthenticatorMethods.CurrentPage != null)
                {
                    authenticationToInitialize.PasswordlessMicrosoftAuthenticatorMethods.AdditionalData = authenticationToInitialize.AdditionalData;

                    object nextPageLink;
                    authenticationToInitialize.AdditionalData.TryGetValue("passwordlessMicrosoftAuthenticatorMethods@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        authenticationToInitialize.PasswordlessMicrosoftAuthenticatorMethods.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (authenticationToInitialize.PasswordMethods != null && authenticationToInitialize.PasswordMethods.CurrentPage != null)
                {
                    authenticationToInitialize.PasswordMethods.AdditionalData = authenticationToInitialize.AdditionalData;

                    object nextPageLink;
                    authenticationToInitialize.AdditionalData.TryGetValue("passwordMethods@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        authenticationToInitialize.PasswordMethods.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (authenticationToInitialize.PhoneMethods != null && authenticationToInitialize.PhoneMethods.CurrentPage != null)
                {
                    authenticationToInitialize.PhoneMethods.AdditionalData = authenticationToInitialize.AdditionalData;

                    object nextPageLink;
                    authenticationToInitialize.AdditionalData.TryGetValue("phoneMethods@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        authenticationToInitialize.PhoneMethods.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (authenticationToInitialize.WindowsHelloForBusinessMethods != null && authenticationToInitialize.WindowsHelloForBusinessMethods.CurrentPage != null)
                {
                    authenticationToInitialize.WindowsHelloForBusinessMethods.AdditionalData = authenticationToInitialize.AdditionalData;

                    object nextPageLink;
                    authenticationToInitialize.AdditionalData.TryGetValue("windowsHelloForBusinessMethods@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        authenticationToInitialize.WindowsHelloForBusinessMethods.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
