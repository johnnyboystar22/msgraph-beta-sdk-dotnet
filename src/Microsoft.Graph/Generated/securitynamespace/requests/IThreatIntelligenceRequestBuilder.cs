// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IThreatIntelligenceRequestBuilder.
    /// </summary>
    public partial interface IThreatIntelligenceRequestBuilder : Microsoft.Graph.IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IThreatIntelligenceRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IThreatIntelligenceRequest Request(IEnumerable<Microsoft.Graph.Option> options);
    
        /// <summary>
        /// Gets the request builder for ArticleIndicators.
        /// </summary>
        /// <returns>The <see cref="IThreatIntelligenceArticleIndicatorsCollectionRequestBuilder"/>.</returns>
        IThreatIntelligenceArticleIndicatorsCollectionRequestBuilder ArticleIndicators { get; }

        /// <summary>
        /// Gets the request builder for Articles.
        /// </summary>
        /// <returns>The <see cref="IThreatIntelligenceArticlesCollectionRequestBuilder"/>.</returns>
        IThreatIntelligenceArticlesCollectionRequestBuilder Articles { get; }

        /// <summary>
        /// Gets the request builder for HostComponents.
        /// </summary>
        /// <returns>The <see cref="IThreatIntelligenceHostComponentsCollectionRequestBuilder"/>.</returns>
        IThreatIntelligenceHostComponentsCollectionRequestBuilder HostComponents { get; }

        /// <summary>
        /// Gets the request builder for HostCookies.
        /// </summary>
        /// <returns>The <see cref="IThreatIntelligenceHostCookiesCollectionRequestBuilder"/>.</returns>
        IThreatIntelligenceHostCookiesCollectionRequestBuilder HostCookies { get; }

        /// <summary>
        /// Gets the request builder for Hosts.
        /// </summary>
        /// <returns>The <see cref="IThreatIntelligenceHostsCollectionRequestBuilder"/>.</returns>
        IThreatIntelligenceHostsCollectionRequestBuilder Hosts { get; }

        /// <summary>
        /// Gets the request builder for HostTrackers.
        /// </summary>
        /// <returns>The <see cref="IThreatIntelligenceHostTrackersCollectionRequestBuilder"/>.</returns>
        IThreatIntelligenceHostTrackersCollectionRequestBuilder HostTrackers { get; }

        /// <summary>
        /// Gets the request builder for IntelligenceProfileIndicators.
        /// </summary>
        /// <returns>The <see cref="IThreatIntelligenceIntelligenceProfileIndicatorsCollectionRequestBuilder"/>.</returns>
        IThreatIntelligenceIntelligenceProfileIndicatorsCollectionRequestBuilder IntelligenceProfileIndicators { get; }

        /// <summary>
        /// Gets the request builder for IntelProfiles.
        /// </summary>
        /// <returns>The <see cref="IThreatIntelligenceIntelProfilesCollectionRequestBuilder"/>.</returns>
        IThreatIntelligenceIntelProfilesCollectionRequestBuilder IntelProfiles { get; }

        /// <summary>
        /// Gets the request builder for PassiveDnsRecords.
        /// </summary>
        /// <returns>The <see cref="IThreatIntelligencePassiveDnsRecordsCollectionRequestBuilder"/>.</returns>
        IThreatIntelligencePassiveDnsRecordsCollectionRequestBuilder PassiveDnsRecords { get; }

        /// <summary>
        /// Gets the request builder for Vulnerabilities.
        /// </summary>
        /// <returns>The <see cref="IThreatIntelligenceVulnerabilitiesCollectionRequestBuilder"/>.</returns>
        IThreatIntelligenceVulnerabilitiesCollectionRequestBuilder Vulnerabilities { get; }
    
    }
}
