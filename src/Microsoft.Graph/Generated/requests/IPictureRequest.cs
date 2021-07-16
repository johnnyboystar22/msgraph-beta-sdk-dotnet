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
    /// The interface IPictureRequest.
    /// </summary>
    public partial interface IPictureRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Picture using POST.
        /// </summary>
        /// <param name="pictureToCreate">The Picture to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Picture.</returns>
        System.Threading.Tasks.Task<Picture> CreateAsync(Picture pictureToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified Picture using POST and returns a <see cref="GraphResponse{Picture}"/> object.
        /// </summary>
        /// <param name="pictureToCreate">The Picture to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Picture}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Picture>> CreateResponseAsync(Picture pictureToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Picture.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Picture and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Picture.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Picture.</returns>
        System.Threading.Tasks.Task<Picture> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Picture and returns a <see cref="GraphResponse{Picture}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Picture}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Picture>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Picture using PATCH.
        /// </summary>
        /// <param name="pictureToUpdate">The Picture to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Picture.</returns>
        System.Threading.Tasks.Task<Picture> UpdateAsync(Picture pictureToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Picture using PATCH and returns a <see cref="GraphResponse{Picture}"/> object.
        /// </summary>
        /// <param name="pictureToUpdate">The Picture to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Picture}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Picture>> UpdateResponseAsync(Picture pictureToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Picture using PUT.
        /// </summary>
        /// <param name="pictureToUpdate">The Picture object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<Picture> PutAsync(Picture pictureToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Picture using PUT and returns a <see cref="GraphResponse{Picture}"/> object.
        /// </summary>
        /// <param name="pictureToUpdate">The Picture object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{Picture}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<Picture>> PutResponseAsync(Picture pictureToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPictureRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPictureRequest Expand(Expression<Func<Picture, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPictureRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPictureRequest Select(Expression<Func<Picture, object>> selectExpression);

    }
}
