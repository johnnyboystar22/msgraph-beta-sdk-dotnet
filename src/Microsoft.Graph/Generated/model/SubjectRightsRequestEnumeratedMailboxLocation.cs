// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type SubjectRightsRequestEnumeratedMailboxLocation.
    /// </summary>
    public partial class SubjectRightsRequestEnumeratedMailboxLocation : SubjectRightsRequestMailboxLocation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubjectRightsRequestEnumeratedMailboxLocation"/> class.
        /// </summary>
        public SubjectRightsRequestEnumeratedMailboxLocation()
        {
            this.ODataType = "microsoft.graph.subjectRightsRequestEnumeratedMailboxLocation";
        }

        /// <summary>
        /// Gets or sets upns.
        /// Collection of mailboxes that should be included in the search. Includes the UPN (user principal name) of each mailbox, for example, Monica.Thompson@contoso.com.
        /// </summary>
        [Obsolete("upns property is deprecated and will stop working on  Dec 23, 2023. Please use the new property caller userPrincipalNames.")]
        [JsonPropertyName("upns")]
        public IEnumerable<string> Upns { get; set; }
    
        /// <summary>
        /// Gets or sets userPrincipalNames.
        /// </summary>
        [JsonPropertyName("userPrincipalNames")]
        public IEnumerable<string> UserPrincipalNames { get; set; }
    
    }
}
