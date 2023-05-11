// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface ICloudPcProvisioningPolicyAssignmentAssignedUsersCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial interface ICloudPcProvisioningPolicyAssignmentAssignedUsersCollectionWithReferencesRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        ICloudPcProvisioningPolicyAssignmentAssignedUsersCollectionWithReferencesRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        ICloudPcProvisioningPolicyAssignmentAssignedUsersCollectionWithReferencesRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IUserWithReferenceRequestBuilder"/> for the specified User.
        /// </summary>
        /// <param name="id">The ID for the User.</param>
        /// <returns>The <see cref="IUserWithReferenceRequestBuilder"/>.</returns>
        IUserWithReferenceRequestBuilder this[string id] { get; }
        
        /// <summary>
        /// Gets an <see cref="ICloudPcProvisioningPolicyAssignmentAssignedUsersCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="ICloudPcProvisioningPolicyAssignmentAssignedUsersCollectionReferencesRequestBuilder"/>.</returns>
        ICloudPcProvisioningPolicyAssignmentAssignedUsersCollectionReferencesRequestBuilder References { get; }

    }
}
