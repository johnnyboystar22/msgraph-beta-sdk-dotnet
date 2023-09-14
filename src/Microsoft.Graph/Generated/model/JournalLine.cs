// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Journal Line.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<JournalLine>))]
    public partial class JournalLine
    {
    
        /// <summary>
        /// Gets or sets account id.
        /// </summary>
        [JsonPropertyName("accountId")]
        public Guid? AccountId { get; set; }
    
        /// <summary>
        /// Gets or sets account number.
        /// </summary>
        [JsonPropertyName("accountNumber")]
        public string AccountNumber { get; set; }
    
        /// <summary>
        /// Gets or sets amount.
        /// </summary>
        [JsonPropertyName("amount")]
        public Decimal? Amount { get; set; }
    
        /// <summary>
        /// Gets or sets comment.
        /// </summary>
        [JsonPropertyName("comment")]
        public string Comment { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets document number.
        /// </summary>
        [JsonPropertyName("documentNumber")]
        public string DocumentNumber { get; set; }
    
        /// <summary>
        /// Gets or sets external document number.
        /// </summary>
        [JsonPropertyName("externalDocumentNumber")]
        public string ExternalDocumentNumber { get; set; }
    
        /// <summary>
        /// Gets or sets id.
        /// </summary>
        [JsonPropertyName("id")]
        public Guid? Id { get; set; }
    
        /// <summary>
        /// Gets or sets journal display name.
        /// </summary>
        [JsonPropertyName("journalDisplayName")]
        public string JournalDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets line number.
        /// </summary>
        [JsonPropertyName("lineNumber")]
        public Int32? LineNumber { get; set; }
    
        /// <summary>
        /// Gets or sets posting date.
        /// </summary>
        [JsonPropertyName("postingDate")]
        public Date PostingDate { get; set; }
    
        /// <summary>
        /// Gets or sets account.
        /// </summary>
        [JsonPropertyName("account")]
        public Account Account { get; set; }
    
        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }

        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}

