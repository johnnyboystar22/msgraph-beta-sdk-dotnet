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
    /// The interface IUnitOfMeasureRequest.
    /// </summary>
    public partial interface IUnitOfMeasureRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UnitOfMeasure using POST.
        /// </summary>
        /// <param name="unitOfMeasureToCreate">The UnitOfMeasure to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UnitOfMeasure.</returns>
        System.Threading.Tasks.Task<UnitOfMeasure> CreateAsync(UnitOfMeasure unitOfMeasureToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified UnitOfMeasure using POST and returns a <see cref="GraphResponse{UnitOfMeasure}"/> object.
        /// </summary>
        /// <param name="unitOfMeasureToCreate">The UnitOfMeasure to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnitOfMeasure}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnitOfMeasure>> CreateResponseAsync(UnitOfMeasure unitOfMeasureToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified UnitOfMeasure.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified UnitOfMeasure and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified UnitOfMeasure.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UnitOfMeasure.</returns>
        System.Threading.Tasks.Task<UnitOfMeasure> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified UnitOfMeasure and returns a <see cref="GraphResponse{UnitOfMeasure}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnitOfMeasure}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnitOfMeasure>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified UnitOfMeasure using PATCH.
        /// </summary>
        /// <param name="unitOfMeasureToUpdate">The UnitOfMeasure to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UnitOfMeasure.</returns>
        System.Threading.Tasks.Task<UnitOfMeasure> UpdateAsync(UnitOfMeasure unitOfMeasureToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified UnitOfMeasure using PATCH and returns a <see cref="GraphResponse{UnitOfMeasure}"/> object.
        /// </summary>
        /// <param name="unitOfMeasureToUpdate">The UnitOfMeasure to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UnitOfMeasure}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnitOfMeasure>> UpdateResponseAsync(UnitOfMeasure unitOfMeasureToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified UnitOfMeasure using PUT.
        /// </summary>
        /// <param name="unitOfMeasureToUpdate">The UnitOfMeasure object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<UnitOfMeasure> PutAsync(UnitOfMeasure unitOfMeasureToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified UnitOfMeasure using PUT and returns a <see cref="GraphResponse{UnitOfMeasure}"/> object.
        /// </summary>
        /// <param name="unitOfMeasureToUpdate">The UnitOfMeasure object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{UnitOfMeasure}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnitOfMeasure>> PutResponseAsync(UnitOfMeasure unitOfMeasureToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnitOfMeasureRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnitOfMeasureRequest Expand(Expression<Func<UnitOfMeasure, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUnitOfMeasureRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUnitOfMeasureRequest Select(Expression<Func<UnitOfMeasure, object>> selectExpression);

    }
}
