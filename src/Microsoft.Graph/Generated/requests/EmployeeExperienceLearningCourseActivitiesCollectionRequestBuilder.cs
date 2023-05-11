// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type EmployeeExperienceLearningCourseActivitiesCollectionRequestBuilder.
    /// </summary>
    public partial class EmployeeExperienceLearningCourseActivitiesCollectionRequestBuilder : BaseRequestBuilder, IEmployeeExperienceLearningCourseActivitiesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new EmployeeExperienceLearningCourseActivitiesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public EmployeeExperienceLearningCourseActivitiesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IEmployeeExperienceLearningCourseActivitiesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IEmployeeExperienceLearningCourseActivitiesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new EmployeeExperienceLearningCourseActivitiesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ILearningCourseActivityRequestBuilder"/> for the specified EmployeeExperienceLearningCourseActivity.
        /// </summary>
        /// <param name="id">The ID for the EmployeeExperienceLearningCourseActivity.</param>
        /// <returns>The <see cref="ILearningCourseActivityRequestBuilder"/>.</returns>
        public ILearningCourseActivityRequestBuilder this[string id]
        {
            get
            {
                return new LearningCourseActivityRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
