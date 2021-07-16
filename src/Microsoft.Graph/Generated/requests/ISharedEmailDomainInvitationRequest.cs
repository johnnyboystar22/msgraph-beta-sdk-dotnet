// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ISharedEmailDomainInvitationRequest.
    /// </summary>
    public partial interface ISharedEmailDomainInvitationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SharedEmailDomainInvitation using POST.
        /// </summary>
        /// <param name="sharedEmailDomainInvitationToCreate">The SharedEmailDomainInvitation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SharedEmailDomainInvitation.</returns>
        System.Threading.Tasks.Task<SharedEmailDomainInvitation> CreateAsync(SharedEmailDomainInvitation sharedEmailDomainInvitationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified SharedEmailDomainInvitation using POST and returns a <see cref="GraphResponse{SharedEmailDomainInvitation}"/> object.
        /// </summary>
        /// <param name="sharedEmailDomainInvitationToCreate">The SharedEmailDomainInvitation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SharedEmailDomainInvitation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SharedEmailDomainInvitation>> CreateResponseAsync(SharedEmailDomainInvitation sharedEmailDomainInvitationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified SharedEmailDomainInvitation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified SharedEmailDomainInvitation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified SharedEmailDomainInvitation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SharedEmailDomainInvitation.</returns>
        System.Threading.Tasks.Task<SharedEmailDomainInvitation> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified SharedEmailDomainInvitation and returns a <see cref="GraphResponse{SharedEmailDomainInvitation}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SharedEmailDomainInvitation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SharedEmailDomainInvitation>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SharedEmailDomainInvitation using PATCH.
        /// </summary>
        /// <param name="sharedEmailDomainInvitationToUpdate">The SharedEmailDomainInvitation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SharedEmailDomainInvitation.</returns>
        System.Threading.Tasks.Task<SharedEmailDomainInvitation> UpdateAsync(SharedEmailDomainInvitation sharedEmailDomainInvitationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SharedEmailDomainInvitation using PATCH and returns a <see cref="GraphResponse{SharedEmailDomainInvitation}"/> object.
        /// </summary>
        /// <param name="sharedEmailDomainInvitationToUpdate">The SharedEmailDomainInvitation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SharedEmailDomainInvitation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SharedEmailDomainInvitation>> UpdateResponseAsync(SharedEmailDomainInvitation sharedEmailDomainInvitationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SharedEmailDomainInvitation using PUT.
        /// </summary>
        /// <param name="sharedEmailDomainInvitationToUpdate">The SharedEmailDomainInvitation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<SharedEmailDomainInvitation> PutAsync(SharedEmailDomainInvitation sharedEmailDomainInvitationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SharedEmailDomainInvitation using PUT and returns a <see cref="GraphResponse{SharedEmailDomainInvitation}"/> object.
        /// </summary>
        /// <param name="sharedEmailDomainInvitationToUpdate">The SharedEmailDomainInvitation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{SharedEmailDomainInvitation}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<SharedEmailDomainInvitation>> PutResponseAsync(SharedEmailDomainInvitation sharedEmailDomainInvitationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISharedEmailDomainInvitationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISharedEmailDomainInvitationRequest Expand(Expression<Func<SharedEmailDomainInvitation, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISharedEmailDomainInvitationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISharedEmailDomainInvitationRequest Select(Expression<Func<SharedEmailDomainInvitation, object>> selectExpression);

    }
}
