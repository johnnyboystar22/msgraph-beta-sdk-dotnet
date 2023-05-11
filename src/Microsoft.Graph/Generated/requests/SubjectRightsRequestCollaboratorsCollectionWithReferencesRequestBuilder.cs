// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type SubjectRightsRequestCollaboratorsCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class SubjectRightsRequestCollaboratorsCollectionWithReferencesRequestBuilder : BaseRequestBuilder, ISubjectRightsRequestCollaboratorsCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new SubjectRightsRequestCollaboratorsCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public SubjectRightsRequestCollaboratorsCollectionWithReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ISubjectRightsRequestCollaboratorsCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ISubjectRightsRequestCollaboratorsCollectionWithReferencesRequest Request(IEnumerable<Option> options)
        {
            return new SubjectRightsRequestCollaboratorsCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IUserWithReferenceRequestBuilder"/> for the specified SubjectRightsRequestUser.
        /// </summary>
        /// <param name="id">The ID for the SubjectRightsRequestUser.</param>
        /// <returns>The <see cref="IUserWithReferenceRequestBuilder"/>.</returns>
        public IUserWithReferenceRequestBuilder this[string id]
        {
            get
            {
                return new UserWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="ISubjectRightsRequestCollaboratorsCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="ISubjectRightsRequestCollaboratorsCollectionReferencesRequestBuilder"/>.</returns>
        public ISubjectRightsRequestCollaboratorsCollectionReferencesRequestBuilder References
        {
            get
            {
                return new SubjectRightsRequestCollaboratorsCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
