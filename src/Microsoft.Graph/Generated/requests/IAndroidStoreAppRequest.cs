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
    /// The interface IAndroidStoreAppRequest.
    /// </summary>
    public partial interface IAndroidStoreAppRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AndroidStoreApp using POST.
        /// </summary>
        /// <param name="androidStoreAppToCreate">The AndroidStoreApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidStoreApp.</returns>
        System.Threading.Tasks.Task<AndroidStoreApp> CreateAsync(AndroidStoreApp androidStoreAppToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified AndroidStoreApp using POST and returns a <see cref="GraphResponse{AndroidStoreApp}"/> object.
        /// </summary>
        /// <param name="androidStoreAppToCreate">The AndroidStoreApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidStoreApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidStoreApp>> CreateResponseAsync(AndroidStoreApp androidStoreAppToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified AndroidStoreApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified AndroidStoreApp and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AndroidStoreApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidStoreApp.</returns>
        System.Threading.Tasks.Task<AndroidStoreApp> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AndroidStoreApp and returns a <see cref="GraphResponse{AndroidStoreApp}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidStoreApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidStoreApp>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AndroidStoreApp using PATCH.
        /// </summary>
        /// <param name="androidStoreAppToUpdate">The AndroidStoreApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidStoreApp.</returns>
        System.Threading.Tasks.Task<AndroidStoreApp> UpdateAsync(AndroidStoreApp androidStoreAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AndroidStoreApp using PATCH and returns a <see cref="GraphResponse{AndroidStoreApp}"/> object.
        /// </summary>
        /// <param name="androidStoreAppToUpdate">The AndroidStoreApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AndroidStoreApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidStoreApp>> UpdateResponseAsync(AndroidStoreApp androidStoreAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AndroidStoreApp using PUT.
        /// </summary>
        /// <param name="androidStoreAppToUpdate">The AndroidStoreApp object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<AndroidStoreApp> PutAsync(AndroidStoreApp androidStoreAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AndroidStoreApp using PUT and returns a <see cref="GraphResponse{AndroidStoreApp}"/> object.
        /// </summary>
        /// <param name="androidStoreAppToUpdate">The AndroidStoreApp object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{AndroidStoreApp}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidStoreApp>> PutResponseAsync(AndroidStoreApp androidStoreAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidStoreAppRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidStoreAppRequest Expand(Expression<Func<AndroidStoreApp, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidStoreAppRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidStoreAppRequest Select(Expression<Func<AndroidStoreApp, object>> selectExpression);

    }
}
