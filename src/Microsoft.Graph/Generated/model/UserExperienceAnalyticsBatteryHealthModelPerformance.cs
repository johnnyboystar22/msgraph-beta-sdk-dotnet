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
    /// The type User Experience Analytics Battery Health Model Performance.
    /// </summary>
    public partial class UserExperienceAnalyticsBatteryHealthModelPerformance : Entity
    {
    
        /// <summary>
        /// Gets or sets active devices.
        /// Number of active devices for that model. Valid values -2147483648 to 2147483647
        /// </summary>
        [JsonPropertyName("activeDevices")]
        public Int32? ActiveDevices { get; set; }
    
        /// <summary>
        /// Gets or sets average battery age in days.
        /// The mean of the battery age for all devices of a given model in a tenant. Unit in days. Valid values -2147483648 to 2147483647
        /// </summary>
        [JsonPropertyName("averageBatteryAgeInDays")]
        public Int32? AverageBatteryAgeInDays { get; set; }
    
        /// <summary>
        /// Gets or sets average estimated runtime in minutes.
        /// The mean of the estimated runtimes on full charge for all devices of a given model. Unit in minutes. Valid values -2147483648 to 2147483647
        /// </summary>
        [JsonPropertyName("averageEstimatedRuntimeInMinutes")]
        public Int32? AverageEstimatedRuntimeInMinutes { get; set; }
    
        /// <summary>
        /// Gets or sets average max capacity percentage.
        /// The mean of the maximum capacity for all devices of a given model. Maximum capacity measures the full charge vs. design capacity for a device’s batteries.. Valid values -2147483648 to 2147483647
        /// </summary>
        [JsonPropertyName("averageMaxCapacityPercentage")]
        public Int32? AverageMaxCapacityPercentage { get; set; }
    
        /// <summary>
        /// Gets or sets manufacturer.
        /// Name of the device manufacturer.
        /// </summary>
        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }
    
        /// <summary>
        /// Gets or sets model.
        /// The model name of the device.
        /// </summary>
        [JsonPropertyName("model")]
        public string Model { get; set; }
    
    }
}

