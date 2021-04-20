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
    /// The type AttendanceInterval.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AttendanceInterval>))]
    public partial class AttendanceInterval
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttendanceInterval"/> class.
        /// </summary>
        public AttendanceInterval()
        {
            this.ODataType = "microsoft.graph.attendanceInterval";
        }

        /// <summary>
        /// Gets or sets durationInSeconds.
        /// Duration of the meeting interval in seconds; that is, the difference between joinDateTime and leaveDateTime.
        /// </summary>
        [JsonPropertyName("durationInSeconds")]
        public Int32? DurationInSeconds { get; set; }
    
        /// <summary>
        /// Gets or sets joinDateTime.
        /// Time attendee joined in UTC.
        /// </summary>
        [JsonPropertyName("joinDateTime")]
        public DateTimeOffset? JoinDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets leaveDateTime.
        /// Time attendee left in UTC.
        /// </summary>
        [JsonPropertyName("leaveDateTime")]
        public DateTimeOffset? LeaveDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
