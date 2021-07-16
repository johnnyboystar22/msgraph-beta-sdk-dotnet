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
    /// The type ProfileRequest.
    /// </summary>
    public partial class ProfileRequest : BaseRequest, IProfileRequest
    {
        /// <summary>
        /// Constructs a new ProfileRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ProfileRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Profile using POST.
        /// </summary>
        /// <param name="profileToCreate">The Profile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Profile.</returns>
        public async System.Threading.Tasks.Task<Profile> CreateAsync(Profile profileToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<Profile>(profileToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified Profile using POST and returns a <see cref="GraphResponse{Profile}"/> object.
        /// </summary>
        /// <param name="profileToCreate">The Profile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Profile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Profile>> CreateResponseAsync(Profile profileToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<Profile>(profileToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified Profile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<Profile>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Profile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified Profile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Profile.</returns>
        public async System.Threading.Tasks.Task<Profile> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<Profile>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified Profile and returns a <see cref="GraphResponse{Profile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Profile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Profile>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<Profile>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Profile using PATCH.
        /// </summary>
        /// <param name="profileToUpdate">The Profile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Profile.</returns>
        public async System.Threading.Tasks.Task<Profile> UpdateAsync(Profile profileToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<Profile>(profileToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Profile using PATCH and returns a <see cref="GraphResponse{Profile}"/> object.
        /// </summary>
        /// <param name="profileToUpdate">The Profile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Profile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Profile>> UpdateResponseAsync(Profile profileToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<Profile>(profileToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Profile using PUT.
        /// </summary>
        /// <param name="profileToUpdate">The Profile object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<Profile> PutAsync(Profile profileToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<Profile>(profileToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Profile using PUT and returns a <see cref="GraphResponse{Profile}"/> object.
        /// </summary>
        /// <param name="profileToUpdate">The Profile object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{Profile}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Profile>> PutResponseAsync(Profile profileToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<Profile>(profileToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IProfileRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IProfileRequest Expand(Expression<Func<Profile, object>> expandExpression)
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
        public IProfileRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IProfileRequest Select(Expression<Func<Profile, object>> selectExpression)
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
        /// <param name="profileToInitialize">The <see cref="Profile"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Profile profileToInitialize)
        {

            if (profileToInitialize != null)
            {
                if (profileToInitialize.Account != null && profileToInitialize.Account.CurrentPage != null)
                {
                    profileToInitialize.Account.InitializeNextPageRequest(this.Client, profileToInitialize.AccountNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    profileToInitialize.Account.AdditionalData = profileToInitialize.AdditionalData;
                }
                if (profileToInitialize.Addresses != null && profileToInitialize.Addresses.CurrentPage != null)
                {
                    profileToInitialize.Addresses.InitializeNextPageRequest(this.Client, profileToInitialize.AddressesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    profileToInitialize.Addresses.AdditionalData = profileToInitialize.AdditionalData;
                }
                if (profileToInitialize.Anniversaries != null && profileToInitialize.Anniversaries.CurrentPage != null)
                {
                    profileToInitialize.Anniversaries.InitializeNextPageRequest(this.Client, profileToInitialize.AnniversariesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    profileToInitialize.Anniversaries.AdditionalData = profileToInitialize.AdditionalData;
                }
                if (profileToInitialize.Awards != null && profileToInitialize.Awards.CurrentPage != null)
                {
                    profileToInitialize.Awards.InitializeNextPageRequest(this.Client, profileToInitialize.AwardsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    profileToInitialize.Awards.AdditionalData = profileToInitialize.AdditionalData;
                }
                if (profileToInitialize.Certifications != null && profileToInitialize.Certifications.CurrentPage != null)
                {
                    profileToInitialize.Certifications.InitializeNextPageRequest(this.Client, profileToInitialize.CertificationsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    profileToInitialize.Certifications.AdditionalData = profileToInitialize.AdditionalData;
                }
                if (profileToInitialize.EducationalActivities != null && profileToInitialize.EducationalActivities.CurrentPage != null)
                {
                    profileToInitialize.EducationalActivities.InitializeNextPageRequest(this.Client, profileToInitialize.EducationalActivitiesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    profileToInitialize.EducationalActivities.AdditionalData = profileToInitialize.AdditionalData;
                }
                if (profileToInitialize.Emails != null && profileToInitialize.Emails.CurrentPage != null)
                {
                    profileToInitialize.Emails.InitializeNextPageRequest(this.Client, profileToInitialize.EmailsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    profileToInitialize.Emails.AdditionalData = profileToInitialize.AdditionalData;
                }
                if (profileToInitialize.Interests != null && profileToInitialize.Interests.CurrentPage != null)
                {
                    profileToInitialize.Interests.InitializeNextPageRequest(this.Client, profileToInitialize.InterestsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    profileToInitialize.Interests.AdditionalData = profileToInitialize.AdditionalData;
                }
                if (profileToInitialize.Languages != null && profileToInitialize.Languages.CurrentPage != null)
                {
                    profileToInitialize.Languages.InitializeNextPageRequest(this.Client, profileToInitialize.LanguagesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    profileToInitialize.Languages.AdditionalData = profileToInitialize.AdditionalData;
                }
                if (profileToInitialize.Names != null && profileToInitialize.Names.CurrentPage != null)
                {
                    profileToInitialize.Names.InitializeNextPageRequest(this.Client, profileToInitialize.NamesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    profileToInitialize.Names.AdditionalData = profileToInitialize.AdditionalData;
                }
                if (profileToInitialize.Notes != null && profileToInitialize.Notes.CurrentPage != null)
                {
                    profileToInitialize.Notes.InitializeNextPageRequest(this.Client, profileToInitialize.NotesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    profileToInitialize.Notes.AdditionalData = profileToInitialize.AdditionalData;
                }
                if (profileToInitialize.Patents != null && profileToInitialize.Patents.CurrentPage != null)
                {
                    profileToInitialize.Patents.InitializeNextPageRequest(this.Client, profileToInitialize.PatentsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    profileToInitialize.Patents.AdditionalData = profileToInitialize.AdditionalData;
                }
                if (profileToInitialize.Phones != null && profileToInitialize.Phones.CurrentPage != null)
                {
                    profileToInitialize.Phones.InitializeNextPageRequest(this.Client, profileToInitialize.PhonesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    profileToInitialize.Phones.AdditionalData = profileToInitialize.AdditionalData;
                }
                if (profileToInitialize.Positions != null && profileToInitialize.Positions.CurrentPage != null)
                {
                    profileToInitialize.Positions.InitializeNextPageRequest(this.Client, profileToInitialize.PositionsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    profileToInitialize.Positions.AdditionalData = profileToInitialize.AdditionalData;
                }
                if (profileToInitialize.Projects != null && profileToInitialize.Projects.CurrentPage != null)
                {
                    profileToInitialize.Projects.InitializeNextPageRequest(this.Client, profileToInitialize.ProjectsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    profileToInitialize.Projects.AdditionalData = profileToInitialize.AdditionalData;
                }
                if (profileToInitialize.Publications != null && profileToInitialize.Publications.CurrentPage != null)
                {
                    profileToInitialize.Publications.InitializeNextPageRequest(this.Client, profileToInitialize.PublicationsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    profileToInitialize.Publications.AdditionalData = profileToInitialize.AdditionalData;
                }
                if (profileToInitialize.Skills != null && profileToInitialize.Skills.CurrentPage != null)
                {
                    profileToInitialize.Skills.InitializeNextPageRequest(this.Client, profileToInitialize.SkillsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    profileToInitialize.Skills.AdditionalData = profileToInitialize.AdditionalData;
                }
                if (profileToInitialize.WebAccounts != null && profileToInitialize.WebAccounts.CurrentPage != null)
                {
                    profileToInitialize.WebAccounts.InitializeNextPageRequest(this.Client, profileToInitialize.WebAccountsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    profileToInitialize.WebAccounts.AdditionalData = profileToInitialize.AdditionalData;
                }
                if (profileToInitialize.Websites != null && profileToInitialize.Websites.CurrentPage != null)
                {
                    profileToInitialize.Websites.InitializeNextPageRequest(this.Client, profileToInitialize.WebsitesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    profileToInitialize.Websites.AdditionalData = profileToInitialize.AdditionalData;
                }

            }


        }
    }
}
