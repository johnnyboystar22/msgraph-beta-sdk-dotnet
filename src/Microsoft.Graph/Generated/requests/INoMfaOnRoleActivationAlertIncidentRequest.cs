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
    /// The interface INoMfaOnRoleActivationAlertIncidentRequest.
    /// </summary>
    public partial interface INoMfaOnRoleActivationAlertIncidentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified NoMfaOnRoleActivationAlertIncident using POST.
        /// </summary>
        /// <param name="noMfaOnRoleActivationAlertIncidentToCreate">The NoMfaOnRoleActivationAlertIncident to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created NoMfaOnRoleActivationAlertIncident.</returns>
        System.Threading.Tasks.Task<NoMfaOnRoleActivationAlertIncident> CreateAsync(NoMfaOnRoleActivationAlertIncident noMfaOnRoleActivationAlertIncidentToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified NoMfaOnRoleActivationAlertIncident using POST and returns a <see cref="GraphResponse{NoMfaOnRoleActivationAlertIncident}"/> object.
        /// </summary>
        /// <param name="noMfaOnRoleActivationAlertIncidentToCreate">The NoMfaOnRoleActivationAlertIncident to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{NoMfaOnRoleActivationAlertIncident}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<NoMfaOnRoleActivationAlertIncident>> CreateResponseAsync(NoMfaOnRoleActivationAlertIncident noMfaOnRoleActivationAlertIncidentToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified NoMfaOnRoleActivationAlertIncident.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified NoMfaOnRoleActivationAlertIncident and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified NoMfaOnRoleActivationAlertIncident.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The NoMfaOnRoleActivationAlertIncident.</returns>
        System.Threading.Tasks.Task<NoMfaOnRoleActivationAlertIncident> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified NoMfaOnRoleActivationAlertIncident and returns a <see cref="GraphResponse{NoMfaOnRoleActivationAlertIncident}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{NoMfaOnRoleActivationAlertIncident}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<NoMfaOnRoleActivationAlertIncident>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified NoMfaOnRoleActivationAlertIncident using PATCH.
        /// </summary>
        /// <param name="noMfaOnRoleActivationAlertIncidentToUpdate">The NoMfaOnRoleActivationAlertIncident to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated NoMfaOnRoleActivationAlertIncident.</returns>
        System.Threading.Tasks.Task<NoMfaOnRoleActivationAlertIncident> UpdateAsync(NoMfaOnRoleActivationAlertIncident noMfaOnRoleActivationAlertIncidentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified NoMfaOnRoleActivationAlertIncident using PATCH and returns a <see cref="GraphResponse{NoMfaOnRoleActivationAlertIncident}"/> object.
        /// </summary>
        /// <param name="noMfaOnRoleActivationAlertIncidentToUpdate">The NoMfaOnRoleActivationAlertIncident to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{NoMfaOnRoleActivationAlertIncident}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<NoMfaOnRoleActivationAlertIncident>> UpdateResponseAsync(NoMfaOnRoleActivationAlertIncident noMfaOnRoleActivationAlertIncidentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified NoMfaOnRoleActivationAlertIncident using PUT.
        /// </summary>
        /// <param name="noMfaOnRoleActivationAlertIncidentToUpdate">The NoMfaOnRoleActivationAlertIncident object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<NoMfaOnRoleActivationAlertIncident> PutAsync(NoMfaOnRoleActivationAlertIncident noMfaOnRoleActivationAlertIncidentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified NoMfaOnRoleActivationAlertIncident using PUT and returns a <see cref="GraphResponse{NoMfaOnRoleActivationAlertIncident}"/> object.
        /// </summary>
        /// <param name="noMfaOnRoleActivationAlertIncidentToUpdate">The NoMfaOnRoleActivationAlertIncident object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{NoMfaOnRoleActivationAlertIncident}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<NoMfaOnRoleActivationAlertIncident>> PutResponseAsync(NoMfaOnRoleActivationAlertIncident noMfaOnRoleActivationAlertIncidentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        INoMfaOnRoleActivationAlertIncidentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        INoMfaOnRoleActivationAlertIncidentRequest Expand(Expression<Func<NoMfaOnRoleActivationAlertIncident, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        INoMfaOnRoleActivationAlertIncidentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        INoMfaOnRoleActivationAlertIncidentRequest Select(Expression<Func<NoMfaOnRoleActivationAlertIncident, object>> selectExpression);

    }
}
