// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph.Networkaccess
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IBranchSiteForwardingProfilesCollectionRequestBuilder.
    /// </summary>
    public partial interface IBranchSiteForwardingProfilesCollectionRequestBuilder : Microsoft.Graph.IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IBranchSiteForwardingProfilesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IBranchSiteForwardingProfilesCollectionRequest Request(IEnumerable<Microsoft.Graph.Option> options);

        /// <summary>
        /// Gets an <see cref="IForwardingProfileRequestBuilder"/> for the specified ForwardingProfile.
        /// </summary>
        /// <param name="id">The ID for the ForwardingProfile.</param>
        /// <returns>The <see cref="IForwardingProfileRequestBuilder"/>.</returns>
        IForwardingProfileRequestBuilder this[string id] { get; }

        
    }
}
