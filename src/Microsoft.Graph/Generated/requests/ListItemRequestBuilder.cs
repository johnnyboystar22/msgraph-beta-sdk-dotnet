// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ListItemRequestBuilder.
    /// </summary>
    public partial class ListItemRequestBuilder : BaseItemRequestBuilder, IListItemRequestBuilder
    {

        /// <summary>
        /// Constructs a new ListItemRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ListItemRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IListItemRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IListItemRequest Request(IEnumerable<Option> options)
        {
            return new ListItemRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Activities.
        /// </summary>
        /// <returns>The <see cref="IListItemActivitiesCollectionRequestBuilder"/>.</returns>
        public IListItemActivitiesCollectionRequestBuilder Activities
        {
            get
            {
                return new ListItemActivitiesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("activities"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Analytics.
        /// </summary>
        /// <returns>The <see cref="IItemAnalyticsWithReferenceRequestBuilder"/>.</returns>
        public IItemAnalyticsWithReferenceRequestBuilder Analytics
        {
            get
            {
                return new ItemAnalyticsWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("analytics"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DocumentSetVersions.
        /// </summary>
        /// <returns>The <see cref="IListItemDocumentSetVersionsCollectionRequestBuilder"/>.</returns>
        public IListItemDocumentSetVersionsCollectionRequestBuilder DocumentSetVersions
        {
            get
            {
                return new ListItemDocumentSetVersionsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("documentSetVersions"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DriveItem.
        /// </summary>
        /// <returns>The <see cref="IDriveItemRequestBuilder"/>.</returns>
        public IDriveItemRequestBuilder DriveItem
        {
            get
            {
                return new DriveItemRequestBuilder(this.AppendSegmentToRequestUrl("driveItem"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Fields.
        /// </summary>
        /// <returns>The <see cref="IFieldValueSetRequestBuilder"/>.</returns>
        public IFieldValueSetRequestBuilder Fields
        {
            get
            {
                return new FieldValueSetRequestBuilder(this.AppendSegmentToRequestUrl("fields"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Versions.
        /// </summary>
        /// <returns>The <see cref="IListItemVersionsCollectionRequestBuilder"/>.</returns>
        public IListItemVersionsCollectionRequestBuilder Versions
        {
            get
            {
                return new ListItemVersionsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("versions"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for ListItemCreateLink.
        /// </summary>
        /// <returns>The <see cref="IListItemCreateLinkRequestBuilder"/>.</returns>
        public IListItemCreateLinkRequestBuilder CreateLink(
            string type = null,
            string scope = null,
            DateTimeOffset? expirationDateTime = null,
            string password = null,
            IEnumerable<DriveRecipient> recipients = null,
            bool? retainInheritedPermissions = null,
            bool? sendNotification = null)
        {
            return new ListItemCreateLinkRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.createLink"),
                this.Client,
                type,
                scope,
                expirationDateTime,
                password,
                recipients,
                retainInheritedPermissions,
                sendNotification);
        }

        /// <summary>
        /// Gets the request builder for ListItemGetActivitiesByInterval.
        /// </summary>
        /// <returns>The <see cref="IListItemGetActivitiesByIntervalRequestBuilder"/>.</returns>
        public IListItemGetActivitiesByIntervalRequestBuilder GetActivitiesByInterval(
            string startDateTime = null,
            string endDateTime = null,
            string interval = null)
        {
            return new ListItemGetActivitiesByIntervalRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getActivitiesByInterval"),
                this.Client,
                startDateTime,
                endDateTime,
                interval);
        }
    
    }
}
