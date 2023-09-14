// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface ILabelsRootDepartmentsCollectionRequestBuilder.
    /// </summary>
    public partial interface ILabelsRootDepartmentsCollectionRequestBuilder : Microsoft.Graph.IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        ILabelsRootDepartmentsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        ILabelsRootDepartmentsCollectionRequest Request(IEnumerable<Microsoft.Graph.Option> options);

        /// <summary>
        /// Gets an <see cref="IDepartmentTemplateRequestBuilder"/> for the specified DepartmentTemplate.
        /// </summary>
        /// <param name="id">The ID for the DepartmentTemplate.</param>
        /// <returns>The <see cref="IDepartmentTemplateRequestBuilder"/>.</returns>
        IDepartmentTemplateRequestBuilder this[string id] { get; }

        
    }
}
