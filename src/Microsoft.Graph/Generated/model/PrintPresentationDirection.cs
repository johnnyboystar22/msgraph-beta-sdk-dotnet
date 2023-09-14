// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum PrintPresentationDirection.
    /// </summary>
    [Obsolete("The presentationDirection enum type is deprecated and will stop returning data on July 31, 2023. Please use the printMultipageLayout enum type instead of this.")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PrintPresentationDirection
    {
    
        /// <summary>
        /// Clockwise From Top Left
        /// </summary>
        ClockwiseFromTopLeft = 0,
	
        /// <summary>
        /// Counter Clockwise From Top Left
        /// </summary>
        CounterClockwiseFromTopLeft = 1,
	
        /// <summary>
        /// Counter Clockwise From Top Right
        /// </summary>
        CounterClockwiseFromTopRight = 2,
	
        /// <summary>
        /// Clockwise From Top Right
        /// </summary>
        ClockwiseFromTopRight = 3,
	
        /// <summary>
        /// Counter Clockwise From Bottom Left
        /// </summary>
        CounterClockwiseFromBottomLeft = 4,
	
        /// <summary>
        /// Clockwise From Bottom Left
        /// </summary>
        ClockwiseFromBottomLeft = 5,
	
        /// <summary>
        /// Counter Clockwise From Bottom Right
        /// </summary>
        CounterClockwiseFromBottomRight = 6,
	
        /// <summary>
        /// Clockwise From Bottom Right
        /// </summary>
        ClockwiseFromBottomRight = 7,
	
    }
}
