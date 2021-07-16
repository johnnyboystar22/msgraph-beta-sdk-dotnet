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
    /// The interface ITaxGroupRequest.
    /// </summary>
    public partial interface ITaxGroupRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified TaxGroup using POST.
        /// </summary>
        /// <param name="taxGroupToCreate">The TaxGroup to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TaxGroup.</returns>
        System.Threading.Tasks.Task<TaxGroup> CreateAsync(TaxGroup taxGroupToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified TaxGroup using POST and returns a <see cref="GraphResponse{TaxGroup}"/> object.
        /// </summary>
        /// <param name="taxGroupToCreate">The TaxGroup to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TaxGroup}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TaxGroup>> CreateResponseAsync(TaxGroup taxGroupToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified TaxGroup.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified TaxGroup and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified TaxGroup.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TaxGroup.</returns>
        System.Threading.Tasks.Task<TaxGroup> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified TaxGroup and returns a <see cref="GraphResponse{TaxGroup}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TaxGroup}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TaxGroup>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TaxGroup using PATCH.
        /// </summary>
        /// <param name="taxGroupToUpdate">The TaxGroup to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TaxGroup.</returns>
        System.Threading.Tasks.Task<TaxGroup> UpdateAsync(TaxGroup taxGroupToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TaxGroup using PATCH and returns a <see cref="GraphResponse{TaxGroup}"/> object.
        /// </summary>
        /// <param name="taxGroupToUpdate">The TaxGroup to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{TaxGroup}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TaxGroup>> UpdateResponseAsync(TaxGroup taxGroupToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TaxGroup using PUT.
        /// </summary>
        /// <param name="taxGroupToUpdate">The TaxGroup object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<TaxGroup> PutAsync(TaxGroup taxGroupToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TaxGroup using PUT and returns a <see cref="GraphResponse{TaxGroup}"/> object.
        /// </summary>
        /// <param name="taxGroupToUpdate">The TaxGroup object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{TaxGroup}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<TaxGroup>> PutResponseAsync(TaxGroup taxGroupToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITaxGroupRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITaxGroupRequest Expand(Expression<Func<TaxGroup, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITaxGroupRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITaxGroupRequest Select(Expression<Func<TaxGroup, object>> selectExpression);

    }
}
