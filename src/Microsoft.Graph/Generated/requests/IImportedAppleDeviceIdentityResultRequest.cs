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
    /// The interface IImportedAppleDeviceIdentityResultRequest.
    /// </summary>
    public partial interface IImportedAppleDeviceIdentityResultRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ImportedAppleDeviceIdentityResult using POST.
        /// </summary>
        /// <param name="importedAppleDeviceIdentityResultToCreate">The ImportedAppleDeviceIdentityResult to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ImportedAppleDeviceIdentityResult.</returns>
        System.Threading.Tasks.Task<ImportedAppleDeviceIdentityResult> CreateAsync(ImportedAppleDeviceIdentityResult importedAppleDeviceIdentityResultToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified ImportedAppleDeviceIdentityResult using POST and returns a <see cref="GraphResponse{ImportedAppleDeviceIdentityResult}"/> object.
        /// </summary>
        /// <param name="importedAppleDeviceIdentityResultToCreate">The ImportedAppleDeviceIdentityResult to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ImportedAppleDeviceIdentityResult}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ImportedAppleDeviceIdentityResult>> CreateResponseAsync(ImportedAppleDeviceIdentityResult importedAppleDeviceIdentityResultToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ImportedAppleDeviceIdentityResult.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ImportedAppleDeviceIdentityResult and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ImportedAppleDeviceIdentityResult.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ImportedAppleDeviceIdentityResult.</returns>
        System.Threading.Tasks.Task<ImportedAppleDeviceIdentityResult> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ImportedAppleDeviceIdentityResult and returns a <see cref="GraphResponse{ImportedAppleDeviceIdentityResult}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ImportedAppleDeviceIdentityResult}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ImportedAppleDeviceIdentityResult>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ImportedAppleDeviceIdentityResult using PATCH.
        /// </summary>
        /// <param name="importedAppleDeviceIdentityResultToUpdate">The ImportedAppleDeviceIdentityResult to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ImportedAppleDeviceIdentityResult.</returns>
        System.Threading.Tasks.Task<ImportedAppleDeviceIdentityResult> UpdateAsync(ImportedAppleDeviceIdentityResult importedAppleDeviceIdentityResultToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ImportedAppleDeviceIdentityResult using PATCH and returns a <see cref="GraphResponse{ImportedAppleDeviceIdentityResult}"/> object.
        /// </summary>
        /// <param name="importedAppleDeviceIdentityResultToUpdate">The ImportedAppleDeviceIdentityResult to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ImportedAppleDeviceIdentityResult}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ImportedAppleDeviceIdentityResult>> UpdateResponseAsync(ImportedAppleDeviceIdentityResult importedAppleDeviceIdentityResultToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ImportedAppleDeviceIdentityResult using PUT.
        /// </summary>
        /// <param name="importedAppleDeviceIdentityResultToUpdate">The ImportedAppleDeviceIdentityResult object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<ImportedAppleDeviceIdentityResult> PutAsync(ImportedAppleDeviceIdentityResult importedAppleDeviceIdentityResultToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ImportedAppleDeviceIdentityResult using PUT and returns a <see cref="GraphResponse{ImportedAppleDeviceIdentityResult}"/> object.
        /// </summary>
        /// <param name="importedAppleDeviceIdentityResultToUpdate">The ImportedAppleDeviceIdentityResult object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{ImportedAppleDeviceIdentityResult}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<ImportedAppleDeviceIdentityResult>> PutResponseAsync(ImportedAppleDeviceIdentityResult importedAppleDeviceIdentityResultToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IImportedAppleDeviceIdentityResultRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IImportedAppleDeviceIdentityResultRequest Expand(Expression<Func<ImportedAppleDeviceIdentityResult, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IImportedAppleDeviceIdentityResultRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IImportedAppleDeviceIdentityResultRequest Select(Expression<Func<ImportedAppleDeviceIdentityResult, object>> selectExpression);

    }
}
