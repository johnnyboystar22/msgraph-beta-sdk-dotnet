// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionWithReferencesRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IB2xIdentityUserFlowUserFlowIdentityProvidersCollectionWithReferencesRequest.
    /// </summary>
    public partial interface IB2xIdentityUserFlowUserFlowIdentityProvidersCollectionWithReferencesRequest : IBaseRequest
    {

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IB2xIdentityUserFlowUserFlowIdentityProvidersCollectionWithReferencesPage> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{B2xIdentityUserFlowUserFlowIdentityProvidersCollectionWithReferencesResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{B2xIdentityUserFlowUserFlowIdentityProvidersCollectionWithReferencesResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<B2xIdentityUserFlowUserFlowIdentityProvidersCollectionWithReferencesResponse>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IB2xIdentityUserFlowUserFlowIdentityProvidersCollectionWithReferencesRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IB2xIdentityUserFlowUserFlowIdentityProvidersCollectionWithReferencesRequest Expand(Expression<Func<IdentityProviderBase, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IB2xIdentityUserFlowUserFlowIdentityProvidersCollectionWithReferencesRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IB2xIdentityUserFlowUserFlowIdentityProvidersCollectionWithReferencesRequest Select(Expression<Func<IdentityProviderBase, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IB2xIdentityUserFlowUserFlowIdentityProvidersCollectionWithReferencesRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IB2xIdentityUserFlowUserFlowIdentityProvidersCollectionWithReferencesRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IB2xIdentityUserFlowUserFlowIdentityProvidersCollectionWithReferencesRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IB2xIdentityUserFlowUserFlowIdentityProvidersCollectionWithReferencesRequest OrderBy(string value);
    }
}
