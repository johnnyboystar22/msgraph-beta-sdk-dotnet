// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IMethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface ISiteGetByPathRequestBuilder.
    /// </summary>
    public partial interface ISiteGetByPathRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        ISiteGetByPathRequest Request(IEnumerable<Option> options = null);
        /// <summary>
        /// Gets the request builder for SiteAddRequestBuilder.
        /// </summary>
        /// <param name="value">A value parameter for the OData method call.</param>
        /// <returns>The <see cref="ISiteAddRequestBuilder"/>.</returns>
        ISiteAddRequestBuilder Add(
            IEnumerable<Site> value);
        /// <summary>
        /// Gets the request builder for SiteDeltaRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="ISiteDeltaRequestBuilder"/>.</returns>
        ISiteDeltaRequestBuilder Delta();
        /// <summary>
        /// Gets the request builder for SiteGetActivitiesByIntervalRequestBuilder.
        /// </summary>
        /// <param name="startDateTime">A startDateTime parameter for the OData method call.</param>
        /// <param name="endDateTime">A endDateTime parameter for the OData method call.</param>
        /// <param name="interval">A interval parameter for the OData method call.</param>
        /// <returns>The <see cref="ISiteGetActivitiesByIntervalRequestBuilder"/>.</returns>
        ISiteGetActivitiesByIntervalRequestBuilder GetActivitiesByInterval(
            string startDateTime,
            string endDateTime,
            string interval);
        /// <summary>
        /// Gets the request builder for SiteGetAllSitesRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="ISiteGetAllSitesRequestBuilder"/>.</returns>
        ISiteGetAllSitesRequestBuilder GetAllSites();
        /// <summary>
        /// Gets the request builder for SiteGetApplicableContentTypesForListRequestBuilder.
        /// </summary>
        /// <param name="listId">A listId parameter for the OData method call.</param>
        /// <returns>The <see cref="ISiteGetApplicableContentTypesForListRequestBuilder"/>.</returns>
        ISiteGetApplicableContentTypesForListRequestBuilder GetApplicableContentTypesForList(
            string listId);
        /// <summary>
        /// Gets the request builder for SiteGetByPathRequestBuilder.
        /// </summary>
        /// <param name="path">A path parameter for the OData method call.</param>
        /// <returns>The <see cref="ISiteGetByPathRequestBuilder"/>.</returns>
        ISiteGetByPathRequestBuilder GetByPath(
            string path);
        /// <summary>
        /// Gets the request builder for SiteRemoveRequestBuilder.
        /// </summary>
        /// <param name="value">A value parameter for the OData method call.</param>
        /// <returns>The <see cref="ISiteRemoveRequestBuilder"/>.</returns>
        ISiteRemoveRequestBuilder Remove(
            IEnumerable<Site> value);
        /// <summary>
        /// Gets the request builder for Analytics.
        /// Analytics about the view activities that took place in this site.
        /// </summary>
        /// <returns>The <see cref="IItemAnalyticsRequestBuilder"/>.</returns>
        IItemAnalyticsRequestBuilder Analytics  { get; }
        /// <summary>
        /// Gets the request builder for Columns.
        /// The collection of column definitions reusable across lists under this site.
        /// </summary>
        /// <returns>The <see cref="IColumnDefinitionRequestBuilder"/>.</returns>
        IColumnDefinitionRequestBuilder Columns  { get; }
        /// <summary>
        /// Gets the request builder for ContentTypes.
        /// The collection of content types defined for this site.
        /// </summary>
        /// <returns>The <see cref="IContentTypeRequestBuilder"/>.</returns>
        IContentTypeRequestBuilder ContentTypes  { get; }
        /// <summary>
        /// Gets the request builder for Drive.
        /// The default drive (document library) for this site.
        /// </summary>
        /// <returns>The <see cref="IDriveRequestBuilder"/>.</returns>
        IDriveRequestBuilder Drive  { get; }
        /// <summary>
        /// Gets the request builder for Drives.
        /// The collection of drives (document libraries) under this site.
        /// </summary>
        /// <returns>The <see cref="IDriveRequestBuilder"/>.</returns>
        IDriveRequestBuilder Drives  { get; }
        /// <summary>
        /// Gets the request builder for ExternalColumns.
        /// The collection of column definitions available in the site that are referenced from the sites in the parent hierarchy of the current site.
        /// </summary>
        /// <returns>The <see cref="IColumnDefinitionRequestBuilder"/>.</returns>
        IColumnDefinitionRequestBuilder ExternalColumns  { get; }
        /// <summary>
        /// Gets the request builder for InformationProtection.
        /// 
        /// </summary>
        /// <returns>The <see cref="IInformationProtectionRequestBuilder"/>.</returns>
        IInformationProtectionRequestBuilder InformationProtection  { get; }
        /// <summary>
        /// Gets the request builder for Items.
        /// Used to address any item contained in this site. This collection cannot be enumerated.
        /// </summary>
        /// <returns>The <see cref="IBaseItemRequestBuilder"/>.</returns>
        IBaseItemRequestBuilder Items  { get; }
        /// <summary>
        /// Gets the request builder for Lists.
        /// The collection of lists under this site.
        /// </summary>
        /// <returns>The <see cref="IListRequestBuilder"/>.</returns>
        IListRequestBuilder Lists  { get; }
        /// <summary>
        /// Gets the request builder for Onenote.
        /// 
        /// </summary>
        /// <returns>The <see cref="IOnenoteRequestBuilder"/>.</returns>
        IOnenoteRequestBuilder Onenote  { get; }
        /// <summary>
        /// Gets the request builder for Operations.
        /// The collection of long running operations for the site.
        /// </summary>
        /// <returns>The <see cref="IRichLongRunningOperationRequestBuilder"/>.</returns>
        IRichLongRunningOperationRequestBuilder Operations  { get; }
        /// <summary>
        /// Gets the request builder for Pages.
        /// The collection of pages in the baseSitePages list in this site.
        /// </summary>
        /// <returns>The <see cref="IBaseSitePageRequestBuilder"/>.</returns>
        IBaseSitePageRequestBuilder Pages  { get; }
        /// <summary>
        /// Gets the request builder for Permissions.
        /// The permissions associated with the site. Nullable.
        /// </summary>
        /// <returns>The <see cref="IPermissionRequestBuilder"/>.</returns>
        IPermissionRequestBuilder Permissions  { get; }
        /// <summary>
        /// Gets the request builder for Sites.
        /// The collection of the sub-sites under this site.
        /// </summary>
        /// <returns>The <see cref="ISiteRequestBuilder"/>.</returns>
        ISiteRequestBuilder Sites  { get; }
        /// <summary>
        /// Gets the request builder for TermStore.
        /// The termStore under this site.
        /// </summary>
        /// <returns>The <see cref="Microsoft.Graph.TermStore.IStoreRequestBuilder"/>.</returns>
        Microsoft.Graph.TermStore.IStoreRequestBuilder TermStore  { get; }
    }
}
