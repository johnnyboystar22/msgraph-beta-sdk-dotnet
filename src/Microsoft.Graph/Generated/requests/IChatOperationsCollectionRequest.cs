// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IChatOperationsCollectionRequest.
    /// </summary>
    public partial interface IChatOperationsCollectionRequest : IBaseRequest
    {
        /// <summary>
        /// Adds the specified TeamsAsyncOperation to the collection via POST.
        /// </summary>
        /// <param name="teamsAsyncOperation">The TeamsAsyncOperation to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TeamsAsyncOperation.</returns>
        System.Threading.Tasks.Task<TeamsAsyncOperation> AddAsync(TeamsAsyncOperation teamsAsyncOperation, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified TeamsAsyncOperation to the collection via POST and returns a <see cref="GraphResponse{TeamsAsyncOperation}"/> object of the request.
        /// </summary>
        /// <param name="teamsAsyncOperation">The TeamsAsyncOperation to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TeamsAsyncOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamsAsyncOperation>> AddResponseAsync(TeamsAsyncOperation teamsAsyncOperation, CancellationToken cancellationToken = default);


        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IChatOperationsCollectionPage> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{ChatOperationsCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ChatOperationsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<ChatOperationsCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IChatOperationsCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IChatOperationsCollectionRequest Expand(Expression<Func<TeamsAsyncOperation, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IChatOperationsCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IChatOperationsCollectionRequest Select(Expression<Func<TeamsAsyncOperation, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IChatOperationsCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IChatOperationsCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IChatOperationsCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IChatOperationsCollectionRequest OrderBy(string value);
    }
}
