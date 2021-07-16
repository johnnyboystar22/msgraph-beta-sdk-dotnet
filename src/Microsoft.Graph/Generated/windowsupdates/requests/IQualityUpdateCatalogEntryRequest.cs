// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph.WindowsUpdates
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IQualityUpdateCatalogEntryRequest.
    /// </summary>
    public partial interface IQualityUpdateCatalogEntryRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Creates the specified QualityUpdateCatalogEntry using POST.
        /// </summary>
        /// <param name="qualityUpdateCatalogEntryToCreate">The QualityUpdateCatalogEntry to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created QualityUpdateCatalogEntry.</returns>
        System.Threading.Tasks.Task<QualityUpdateCatalogEntry> CreateAsync(QualityUpdateCatalogEntry qualityUpdateCatalogEntryToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified QualityUpdateCatalogEntry using POST and returns a <see cref="GraphResponse{QualityUpdateCatalogEntry}"/> object.
        /// </summary>
        /// <param name="qualityUpdateCatalogEntryToCreate">The QualityUpdateCatalogEntry to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{QualityUpdateCatalogEntry}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<QualityUpdateCatalogEntry>> CreateResponseAsync(QualityUpdateCatalogEntry qualityUpdateCatalogEntryToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified QualityUpdateCatalogEntry.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified QualityUpdateCatalogEntry and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified QualityUpdateCatalogEntry.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The QualityUpdateCatalogEntry.</returns>
        System.Threading.Tasks.Task<QualityUpdateCatalogEntry> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified QualityUpdateCatalogEntry and returns a <see cref="GraphResponse{QualityUpdateCatalogEntry}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{QualityUpdateCatalogEntry}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<QualityUpdateCatalogEntry>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified QualityUpdateCatalogEntry using PATCH.
        /// </summary>
        /// <param name="qualityUpdateCatalogEntryToUpdate">The QualityUpdateCatalogEntry to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated QualityUpdateCatalogEntry.</returns>
        System.Threading.Tasks.Task<QualityUpdateCatalogEntry> UpdateAsync(QualityUpdateCatalogEntry qualityUpdateCatalogEntryToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified QualityUpdateCatalogEntry using PATCH and returns a <see cref="GraphResponse{QualityUpdateCatalogEntry}"/> object.
        /// </summary>
        /// <param name="qualityUpdateCatalogEntryToUpdate">The QualityUpdateCatalogEntry to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{QualityUpdateCatalogEntry}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<QualityUpdateCatalogEntry>> UpdateResponseAsync(QualityUpdateCatalogEntry qualityUpdateCatalogEntryToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified QualityUpdateCatalogEntry using PUT.
        /// </summary>
        /// <param name="qualityUpdateCatalogEntryToUpdate">The QualityUpdateCatalogEntry object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<QualityUpdateCatalogEntry> PutAsync(QualityUpdateCatalogEntry qualityUpdateCatalogEntryToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified QualityUpdateCatalogEntry using PUT and returns a <see cref="GraphResponse{QualityUpdateCatalogEntry}"/> object.
        /// </summary>
        /// <param name="qualityUpdateCatalogEntryToUpdate">The QualityUpdateCatalogEntry object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{QualityUpdateCatalogEntry}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<QualityUpdateCatalogEntry>> PutResponseAsync(QualityUpdateCatalogEntry qualityUpdateCatalogEntryToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IQualityUpdateCatalogEntryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IQualityUpdateCatalogEntryRequest Expand(Expression<Func<QualityUpdateCatalogEntry, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IQualityUpdateCatalogEntryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IQualityUpdateCatalogEntryRequest Select(Expression<Func<QualityUpdateCatalogEntry, object>> selectExpression);

    }
}
