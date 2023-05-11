// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ICustomCalloutExtensionWithReferenceRequest.
    /// </summary>
    public partial interface ICustomCalloutExtensionWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified CustomCalloutExtension.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CustomCalloutExtension.</returns>
        System.Threading.Tasks.Task<CustomCalloutExtension> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified CustomCalloutExtension and returns a <see cref="GraphResponse{CustomCalloutExtension}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CustomCalloutExtension}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CustomCalloutExtension>> GetResponseAsync(CancellationToken cancellationToken = default);

		/// <summary>
        /// Creates the specified CustomCalloutExtension using POST.
        /// </summary>
        /// <param name="customCalloutExtensionToCreate">The CustomCalloutExtension to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CustomCalloutExtension.</returns>
        System.Threading.Tasks.Task<CustomCalloutExtension> CreateAsync(CustomCalloutExtension customCalloutExtensionToCreate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Creates the specified CustomCalloutExtension using POST and returns a <see cref="GraphResponse{CustomCalloutExtension}"/> object.
        /// </summary>
        /// <param name="customCalloutExtensionToCreate">The CustomCalloutExtension to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CustomCalloutExtension}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CustomCalloutExtension>> CreateResponseAsync(CustomCalloutExtension customCalloutExtensionToCreate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Updates the specified CustomCalloutExtension using PATCH.
        /// </summary>
        /// <param name="customCalloutExtensionToUpdate">The CustomCalloutExtension to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CustomCalloutExtension.</returns>
        System.Threading.Tasks.Task<CustomCalloutExtension> UpdateAsync(CustomCalloutExtension customCalloutExtensionToUpdate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Updates the specified CustomCalloutExtension using PATCH and returns a <see cref="GraphResponse{CustomCalloutExtension}"/> object.
        /// </summary>
        /// <param name="customCalloutExtensionToUpdate">The CustomCalloutExtension to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{CustomCalloutExtension}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CustomCalloutExtension>> UpdateResponseAsync(CustomCalloutExtension customCalloutExtensionToUpdate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Deletes the specified CustomCalloutExtension.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

		/// <summary>
        /// Deletes the specified CustomCalloutExtension and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICustomCalloutExtensionWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICustomCalloutExtensionWithReferenceRequest Expand(Expression<Func<CustomCalloutExtension, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICustomCalloutExtensionWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICustomCalloutExtensionWithReferenceRequest Select(Expression<Func<CustomCalloutExtension, object>> selectExpression);

    }
}
