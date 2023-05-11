// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IGraphServiceDirectoryObjectsCollectionRequestBuilder.
    /// </summary>
    public partial interface IGraphServiceDirectoryObjectsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IGraphServiceDirectoryObjectsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IGraphServiceDirectoryObjectsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IDirectoryObjectRequestBuilder"/> for the specified DirectoryObject.
        /// </summary>
        /// <param name="id">The ID for the DirectoryObject.</param>
        /// <returns>The <see cref="IDirectoryObjectRequestBuilder"/>.</returns>
        IDirectoryObjectRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for DirectoryObjectValidateProperties.
        /// </summary>
        /// <returns>The <see cref="IDirectoryObjectValidatePropertiesRequestBuilder"/>.</returns>
        IDirectoryObjectValidatePropertiesRequestBuilder ValidateProperties(
            string entityType = null,
            string displayName = null,
            string mailNickname = null,
            Guid? onBehalfOfUserId = null);

        /// <summary>
        /// Gets the request builder for DirectoryObjectGetByIds.
        /// </summary>
        /// <returns>The <see cref="IDirectoryObjectGetByIdsRequestBuilder"/>.</returns>
        IDirectoryObjectGetByIdsRequestBuilder GetByIds(
            IEnumerable<string> ids,
            IEnumerable<string> types = null);

        /// <summary>
        /// Gets the request builder for DirectoryObjectGetUserOwnedObjects.
        /// </summary>
        /// <returns>The <see cref="IDirectoryObjectGetUserOwnedObjectsRequestBuilder"/>.</returns>
        IDirectoryObjectGetUserOwnedObjectsRequestBuilder GetUserOwnedObjects(
            string userId = null,
            string type = null);

        /// <summary>
        /// Gets the request builder for DirectoryObjectDelta.
        /// </summary>
        /// <returns>The <see cref="IDirectoryObjectDeltaRequestBuilder"/>.</returns>
        IDirectoryObjectDeltaRequestBuilder Delta();
    }
}
