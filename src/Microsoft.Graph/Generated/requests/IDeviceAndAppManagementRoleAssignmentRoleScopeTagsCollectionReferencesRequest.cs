// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionReferencesRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IDeviceAndAppManagementRoleAssignmentRoleScopeTagsCollectionReferencesRequest.
    /// </summary>
    public partial interface IDeviceAndAppManagementRoleAssignmentRoleScopeTagsCollectionReferencesRequest : IBaseRequest
    {
        /// <summary>
        /// Adds the specified RoleScopeTag to the collection via POST.
        /// </summary>
        /// <param name="roleScopeTag">The RoleScopeTag to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        System.Threading.Tasks.Task AddAsync(RoleScopeTag roleScopeTag, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified RoleScopeTag to the collection via POST and returns a <see cref="GraphResponse{RoleScopeTag}"/> object of the request.
        /// </summary>
        /// <param name="roleScopeTag">The RoleScopeTag to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        System.Threading.Tasks.Task<GraphResponse> AddResponseAsync(RoleScopeTag roleScopeTag, CancellationToken cancellationToken = default);

    }
}
