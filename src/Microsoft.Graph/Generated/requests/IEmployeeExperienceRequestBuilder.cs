// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IEmployeeExperienceRequestBuilder.
    /// </summary>
    public partial interface IEmployeeExperienceRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IEmployeeExperienceRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IEmployeeExperienceRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for LearningCourseActivities.
        /// </summary>
        /// <returns>The <see cref="IEmployeeExperienceLearningCourseActivitiesCollectionRequestBuilder"/>.</returns>
        IEmployeeExperienceLearningCourseActivitiesCollectionRequestBuilder LearningCourseActivities { get; }

        /// <summary>
        /// Gets the request builder for LearningProviders.
        /// </summary>
        /// <returns>The <see cref="IEmployeeExperienceLearningProvidersCollectionRequestBuilder"/>.</returns>
        IEmployeeExperienceLearningProvidersCollectionRequestBuilder LearningProviders { get; }
    
    }
}
