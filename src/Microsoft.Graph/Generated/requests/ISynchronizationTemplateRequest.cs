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
    /// The interface ISynchronizationTemplateRequest.
    /// </summary>
    public partial interface ISynchronizationTemplateRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SynchronizationTemplate using POST.
        /// </summary>
        /// <param name="synchronizationTemplateToCreate">The SynchronizationTemplate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SynchronizationTemplate.</returns>
        System.Threading.Tasks.Task<SynchronizationTemplate> CreateAsync(SynchronizationTemplate synchronizationTemplateToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified SynchronizationTemplate using POST and returns a <see cref="GraphResponse{SynchronizationTemplate}"/> object.
        /// </summary>
        /// <param name="synchronizationTemplateToCreate">The SynchronizationTemplate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SynchronizationTemplate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SynchronizationTemplate>> CreateResponseAsync(SynchronizationTemplate synchronizationTemplateToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified SynchronizationTemplate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified SynchronizationTemplate and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified SynchronizationTemplate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SynchronizationTemplate.</returns>
        System.Threading.Tasks.Task<SynchronizationTemplate> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified SynchronizationTemplate and returns a <see cref="GraphResponse{SynchronizationTemplate}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SynchronizationTemplate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SynchronizationTemplate>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SynchronizationTemplate using PATCH.
        /// </summary>
        /// <param name="synchronizationTemplateToUpdate">The SynchronizationTemplate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SynchronizationTemplate.</returns>
        System.Threading.Tasks.Task<SynchronizationTemplate> UpdateAsync(SynchronizationTemplate synchronizationTemplateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SynchronizationTemplate using PATCH and returns a <see cref="GraphResponse{SynchronizationTemplate}"/> object.
        /// </summary>
        /// <param name="synchronizationTemplateToUpdate">The SynchronizationTemplate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SynchronizationTemplate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SynchronizationTemplate>> UpdateResponseAsync(SynchronizationTemplate synchronizationTemplateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SynchronizationTemplate using PUT.
        /// </summary>
        /// <param name="synchronizationTemplateToUpdate">The SynchronizationTemplate object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<SynchronizationTemplate> PutAsync(SynchronizationTemplate synchronizationTemplateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SynchronizationTemplate using PUT and returns a <see cref="GraphResponse{SynchronizationTemplate}"/> object.
        /// </summary>
        /// <param name="synchronizationTemplateToUpdate">The SynchronizationTemplate object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{SynchronizationTemplate}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<SynchronizationTemplate>> PutResponseAsync(SynchronizationTemplate synchronizationTemplateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISynchronizationTemplateRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISynchronizationTemplateRequest Expand(Expression<Func<SynchronizationTemplate, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISynchronizationTemplateRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISynchronizationTemplateRequest Select(Expression<Func<SynchronizationTemplate, object>> selectExpression);

    }
}
