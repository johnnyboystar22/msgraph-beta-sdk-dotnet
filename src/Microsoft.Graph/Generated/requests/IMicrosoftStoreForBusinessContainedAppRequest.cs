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
    /// The interface IMicrosoftStoreForBusinessContainedAppRequest.
    /// </summary>
    public partial interface IMicrosoftStoreForBusinessContainedAppRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MicrosoftStoreForBusinessContainedApp using POST.
        /// </summary>
        /// <param name="microsoftStoreForBusinessContainedAppToCreate">The MicrosoftStoreForBusinessContainedApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MicrosoftStoreForBusinessContainedApp.</returns>
        System.Threading.Tasks.Task<MicrosoftStoreForBusinessContainedApp> CreateAsync(MicrosoftStoreForBusinessContainedApp microsoftStoreForBusinessContainedAppToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified MicrosoftStoreForBusinessContainedApp using POST and returns a <see cref="GraphResponse{MicrosoftStoreForBusinessContainedApp}"/> object.
        /// </summary>
        /// <param name="microsoftStoreForBusinessContainedAppToCreate">The MicrosoftStoreForBusinessContainedApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MicrosoftStoreForBusinessContainedApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MicrosoftStoreForBusinessContainedApp>> CreateResponseAsync(MicrosoftStoreForBusinessContainedApp microsoftStoreForBusinessContainedAppToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified MicrosoftStoreForBusinessContainedApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified MicrosoftStoreForBusinessContainedApp and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified MicrosoftStoreForBusinessContainedApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MicrosoftStoreForBusinessContainedApp.</returns>
        System.Threading.Tasks.Task<MicrosoftStoreForBusinessContainedApp> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified MicrosoftStoreForBusinessContainedApp and returns a <see cref="GraphResponse{MicrosoftStoreForBusinessContainedApp}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MicrosoftStoreForBusinessContainedApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MicrosoftStoreForBusinessContainedApp>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MicrosoftStoreForBusinessContainedApp using PATCH.
        /// </summary>
        /// <param name="microsoftStoreForBusinessContainedAppToUpdate">The MicrosoftStoreForBusinessContainedApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MicrosoftStoreForBusinessContainedApp.</returns>
        System.Threading.Tasks.Task<MicrosoftStoreForBusinessContainedApp> UpdateAsync(MicrosoftStoreForBusinessContainedApp microsoftStoreForBusinessContainedAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MicrosoftStoreForBusinessContainedApp using PATCH and returns a <see cref="GraphResponse{MicrosoftStoreForBusinessContainedApp}"/> object.
        /// </summary>
        /// <param name="microsoftStoreForBusinessContainedAppToUpdate">The MicrosoftStoreForBusinessContainedApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MicrosoftStoreForBusinessContainedApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MicrosoftStoreForBusinessContainedApp>> UpdateResponseAsync(MicrosoftStoreForBusinessContainedApp microsoftStoreForBusinessContainedAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MicrosoftStoreForBusinessContainedApp using PUT.
        /// </summary>
        /// <param name="microsoftStoreForBusinessContainedAppToUpdate">The MicrosoftStoreForBusinessContainedApp object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<MicrosoftStoreForBusinessContainedApp> PutAsync(MicrosoftStoreForBusinessContainedApp microsoftStoreForBusinessContainedAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MicrosoftStoreForBusinessContainedApp using PUT and returns a <see cref="GraphResponse{MicrosoftStoreForBusinessContainedApp}"/> object.
        /// </summary>
        /// <param name="microsoftStoreForBusinessContainedAppToUpdate">The MicrosoftStoreForBusinessContainedApp object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{MicrosoftStoreForBusinessContainedApp}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<MicrosoftStoreForBusinessContainedApp>> PutResponseAsync(MicrosoftStoreForBusinessContainedApp microsoftStoreForBusinessContainedAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMicrosoftStoreForBusinessContainedAppRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMicrosoftStoreForBusinessContainedAppRequest Expand(Expression<Func<MicrosoftStoreForBusinessContainedApp, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMicrosoftStoreForBusinessContainedAppRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMicrosoftStoreForBusinessContainedAppRequest Select(Expression<Func<MicrosoftStoreForBusinessContainedApp, object>> selectExpression);

    }
}
