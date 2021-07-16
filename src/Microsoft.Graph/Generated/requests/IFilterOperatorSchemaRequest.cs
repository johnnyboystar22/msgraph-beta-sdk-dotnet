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
    /// The interface IFilterOperatorSchemaRequest.
    /// </summary>
    public partial interface IFilterOperatorSchemaRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified FilterOperatorSchema using POST.
        /// </summary>
        /// <param name="filterOperatorSchemaToCreate">The FilterOperatorSchema to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created FilterOperatorSchema.</returns>
        System.Threading.Tasks.Task<FilterOperatorSchema> CreateAsync(FilterOperatorSchema filterOperatorSchemaToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified FilterOperatorSchema using POST and returns a <see cref="GraphResponse{FilterOperatorSchema}"/> object.
        /// </summary>
        /// <param name="filterOperatorSchemaToCreate">The FilterOperatorSchema to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{FilterOperatorSchema}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<FilterOperatorSchema>> CreateResponseAsync(FilterOperatorSchema filterOperatorSchemaToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified FilterOperatorSchema.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified FilterOperatorSchema and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified FilterOperatorSchema.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The FilterOperatorSchema.</returns>
        System.Threading.Tasks.Task<FilterOperatorSchema> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified FilterOperatorSchema and returns a <see cref="GraphResponse{FilterOperatorSchema}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{FilterOperatorSchema}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<FilterOperatorSchema>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified FilterOperatorSchema using PATCH.
        /// </summary>
        /// <param name="filterOperatorSchemaToUpdate">The FilterOperatorSchema to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated FilterOperatorSchema.</returns>
        System.Threading.Tasks.Task<FilterOperatorSchema> UpdateAsync(FilterOperatorSchema filterOperatorSchemaToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified FilterOperatorSchema using PATCH and returns a <see cref="GraphResponse{FilterOperatorSchema}"/> object.
        /// </summary>
        /// <param name="filterOperatorSchemaToUpdate">The FilterOperatorSchema to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{FilterOperatorSchema}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<FilterOperatorSchema>> UpdateResponseAsync(FilterOperatorSchema filterOperatorSchemaToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified FilterOperatorSchema using PUT.
        /// </summary>
        /// <param name="filterOperatorSchemaToUpdate">The FilterOperatorSchema object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<FilterOperatorSchema> PutAsync(FilterOperatorSchema filterOperatorSchemaToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified FilterOperatorSchema using PUT and returns a <see cref="GraphResponse{FilterOperatorSchema}"/> object.
        /// </summary>
        /// <param name="filterOperatorSchemaToUpdate">The FilterOperatorSchema object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{FilterOperatorSchema}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<FilterOperatorSchema>> PutResponseAsync(FilterOperatorSchema filterOperatorSchemaToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IFilterOperatorSchemaRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IFilterOperatorSchemaRequest Expand(Expression<Func<FilterOperatorSchema, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IFilterOperatorSchemaRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IFilterOperatorSchemaRequest Select(Expression<Func<FilterOperatorSchema, object>> selectExpression);

    }
}
