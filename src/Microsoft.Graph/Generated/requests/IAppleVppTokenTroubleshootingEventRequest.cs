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
    /// The interface IAppleVppTokenTroubleshootingEventRequest.
    /// </summary>
    public partial interface IAppleVppTokenTroubleshootingEventRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AppleVppTokenTroubleshootingEvent using POST.
        /// </summary>
        /// <param name="appleVppTokenTroubleshootingEventToCreate">The AppleVppTokenTroubleshootingEvent to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AppleVppTokenTroubleshootingEvent.</returns>
        System.Threading.Tasks.Task<AppleVppTokenTroubleshootingEvent> CreateAsync(AppleVppTokenTroubleshootingEvent appleVppTokenTroubleshootingEventToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified AppleVppTokenTroubleshootingEvent using POST and returns a <see cref="GraphResponse{AppleVppTokenTroubleshootingEvent}"/> object.
        /// </summary>
        /// <param name="appleVppTokenTroubleshootingEventToCreate">The AppleVppTokenTroubleshootingEvent to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AppleVppTokenTroubleshootingEvent}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AppleVppTokenTroubleshootingEvent>> CreateResponseAsync(AppleVppTokenTroubleshootingEvent appleVppTokenTroubleshootingEventToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified AppleVppTokenTroubleshootingEvent.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified AppleVppTokenTroubleshootingEvent and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AppleVppTokenTroubleshootingEvent.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AppleVppTokenTroubleshootingEvent.</returns>
        System.Threading.Tasks.Task<AppleVppTokenTroubleshootingEvent> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AppleVppTokenTroubleshootingEvent and returns a <see cref="GraphResponse{AppleVppTokenTroubleshootingEvent}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AppleVppTokenTroubleshootingEvent}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AppleVppTokenTroubleshootingEvent>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AppleVppTokenTroubleshootingEvent using PATCH.
        /// </summary>
        /// <param name="appleVppTokenTroubleshootingEventToUpdate">The AppleVppTokenTroubleshootingEvent to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AppleVppTokenTroubleshootingEvent.</returns>
        System.Threading.Tasks.Task<AppleVppTokenTroubleshootingEvent> UpdateAsync(AppleVppTokenTroubleshootingEvent appleVppTokenTroubleshootingEventToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AppleVppTokenTroubleshootingEvent using PATCH and returns a <see cref="GraphResponse{AppleVppTokenTroubleshootingEvent}"/> object.
        /// </summary>
        /// <param name="appleVppTokenTroubleshootingEventToUpdate">The AppleVppTokenTroubleshootingEvent to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AppleVppTokenTroubleshootingEvent}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AppleVppTokenTroubleshootingEvent>> UpdateResponseAsync(AppleVppTokenTroubleshootingEvent appleVppTokenTroubleshootingEventToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AppleVppTokenTroubleshootingEvent using PUT.
        /// </summary>
        /// <param name="appleVppTokenTroubleshootingEventToUpdate">The AppleVppTokenTroubleshootingEvent object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<AppleVppTokenTroubleshootingEvent> PutAsync(AppleVppTokenTroubleshootingEvent appleVppTokenTroubleshootingEventToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AppleVppTokenTroubleshootingEvent using PUT and returns a <see cref="GraphResponse{AppleVppTokenTroubleshootingEvent}"/> object.
        /// </summary>
        /// <param name="appleVppTokenTroubleshootingEventToUpdate">The AppleVppTokenTroubleshootingEvent object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{AppleVppTokenTroubleshootingEvent}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<AppleVppTokenTroubleshootingEvent>> PutResponseAsync(AppleVppTokenTroubleshootingEvent appleVppTokenTroubleshootingEventToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAppleVppTokenTroubleshootingEventRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAppleVppTokenTroubleshootingEventRequest Expand(Expression<Func<AppleVppTokenTroubleshootingEvent, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAppleVppTokenTroubleshootingEventRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAppleVppTokenTroubleshootingEventRequest Select(Expression<Func<AppleVppTokenTroubleshootingEvent, object>> selectExpression);

    }
}
