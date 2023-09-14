// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionWithReferencesPage.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;

    /// <summary>
    /// The type HostSslCertificatesCollectionWithReferencesPage.
    /// </summary>
    public partial class HostSslCertificatesCollectionWithReferencesPage : Microsoft.Graph.CollectionPage<HostSslCertificate>, IHostSslCertificatesCollectionWithReferencesPage
    {
        /// <summary>
        /// Gets the next page <see cref="IHostSslCertificatesCollectionWithReferencesRequest"/> instance.
        /// </summary>
        public IHostSslCertificatesCollectionWithReferencesRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(Microsoft.Graph.IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new HostSslCertificatesCollectionWithReferencesRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}
