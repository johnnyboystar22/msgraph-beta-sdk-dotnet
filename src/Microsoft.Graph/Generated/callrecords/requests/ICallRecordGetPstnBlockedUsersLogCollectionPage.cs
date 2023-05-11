// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IMethodCollectionPage.cs.tt

namespace Microsoft.Graph.CallRecords
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The interface ICallRecordGetPstnBlockedUsersLogCollectionPage.
    /// </summary>
    [InterfaceConverter(typeof(Microsoft.Graph.InterfaceConverter<CallRecordGetPstnBlockedUsersLogCollectionPage>))]
    public interface ICallRecordGetPstnBlockedUsersLogCollectionPage : Microsoft.Graph.ICollectionPage<PstnBlockedUsersLogRow>
    {
        /// <summary>
        /// Gets the next page <see cref="ICallRecordGetPstnBlockedUsersLogRequest"/> instance.
        /// </summary>
        ICallRecordGetPstnBlockedUsersLogRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(Microsoft.Graph.IBaseClient client, string nextPageLinkString);
    }
}
