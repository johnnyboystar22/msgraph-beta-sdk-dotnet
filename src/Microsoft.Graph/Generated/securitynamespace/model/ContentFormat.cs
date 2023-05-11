// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph.SecurityNamespace
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum ContentFormat.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ContentFormat
    {
    
        /// <summary>
        /// Text
        /// </summary>
        Text = 0,
	
        /// <summary>
        /// Html
        /// </summary>
        Html = 1,
	
        /// <summary>
        /// Markdown
        /// </summary>
        Markdown = 2,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 3,
	
    }
}
