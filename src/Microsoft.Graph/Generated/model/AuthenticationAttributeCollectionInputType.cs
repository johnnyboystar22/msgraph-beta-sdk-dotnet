// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum AuthenticationAttributeCollectionInputType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AuthenticationAttributeCollectionInputType
    {
    
        /// <summary>
        /// Text
        /// </summary>
        Text = 1,
	
        /// <summary>
        /// Radio Single Select
        /// </summary>
        RadioSingleSelect = 2,
	
        /// <summary>
        /// Checkbox Multi Select
        /// </summary>
        CheckboxMultiSelect = 3,
	
        /// <summary>
        /// Boolean
        /// </summary>
        Boolean = 4,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 5,
	
    }
}
