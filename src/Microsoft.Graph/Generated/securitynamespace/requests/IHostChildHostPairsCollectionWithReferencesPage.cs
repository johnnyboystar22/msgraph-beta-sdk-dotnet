// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionWithReferencesPage.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The interface IHostChildHostPairsCollectionWithReferencesPage.
    /// </summary>
    [InterfaceConverter(typeof(Microsoft.Graph.InterfaceConverter<HostChildHostPairsCollectionWithReferencesPage>))]
    public interface IHostChildHostPairsCollectionWithReferencesPage : Microsoft.Graph.ICollectionPage<HostPair>
    {
        /// <summary>
        /// Gets the next page <see cref="IHostChildHostPairsCollectionWithReferencesRequest"/> instance.
        /// </summary>
        IHostChildHostPairsCollectionWithReferencesRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(Microsoft.Graph.IBaseClient client, string nextPageLinkString);
    }
}
