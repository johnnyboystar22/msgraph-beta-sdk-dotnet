// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph.WindowsUpdates
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type UpdatableAssetRemoveMembersByIdRequestBuilder.
    /// </summary>
    public partial class UpdatableAssetRemoveMembersByIdRequestBuilder : Microsoft.Graph.BaseActionMethodRequestBuilder<IUpdatableAssetRemoveMembersByIdRequest>, IUpdatableAssetRemoveMembersByIdRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="UpdatableAssetRemoveMembersByIdRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="ids">A ids parameter for the OData method call.</param>
        /// <param name="memberEntityType">A memberEntityType parameter for the OData method call.</param>
        public UpdatableAssetRemoveMembersByIdRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<string> ids,
            string memberEntityType)
            : base(requestUrl, client)
        {
            this.SetParameter("ids", ids, true);
            this.SetParameter("memberEntityType", memberEntityType, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IUpdatableAssetRemoveMembersByIdRequest CreateRequest(string functionUrl, IEnumerable<Microsoft.Graph.Option> options)
        {
            var request = new UpdatableAssetRemoveMembersByIdRequest(functionUrl, this.Client, options);

            if (this.HasParameter("ids"))
            {
                request.RequestBody.Ids = this.GetParameter<IEnumerable<string>>("ids");
            }

            if (this.HasParameter("memberEntityType"))
            {
                request.RequestBody.MemberEntityType = this.GetParameter<string>("memberEntityType");
            }

            return request;
        }
    }
}
