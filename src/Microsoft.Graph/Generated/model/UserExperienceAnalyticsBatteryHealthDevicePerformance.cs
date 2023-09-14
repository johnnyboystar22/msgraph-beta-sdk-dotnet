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
    /// The type User Experience Analytics Battery Health Device Performance.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<UserExperienceAnalyticsBatteryHealthDevicePerformance>))]
    public partial class UserExperienceAnalyticsBatteryHealthDevicePerformance : Entity
    {
    
        /// <summary>
        /// Gets or sets battery age in days.
        /// Estimated battery age. Unit in days. Valid values 0 to 2147483647
        /// </summary>
        [JsonPropertyName("batteryAgeInDays")]
        public Int32? BatteryAgeInDays { get; set; }
    
        /// <summary>
        /// Gets or sets device battery count.
        /// Number of batteries in a user device. Valid values 1 to 2147483647
        /// </summary>
        [JsonPropertyName("deviceBatteryCount")]
        public Int32? DeviceBatteryCount { get; set; }
    
        /// <summary>
        /// Gets or sets device battery health score.
        /// A weighted average of a device’s maximum capacity score and runtime estimate score. Values range from 0-100. Valid values 0 to 2147483647
        /// </summary>
        [JsonPropertyName("deviceBatteryHealthScore")]
        public Int32? DeviceBatteryHealthScore { get; set; }
    
        /// <summary>
        /// Gets or sets device id.
        /// The unique identifier of the device, Intune DeviceID.
        /// </summary>
        [JsonPropertyName("deviceId")]
        public string DeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets device name.
        /// Device friendly name.
        /// </summary>
        [JsonPropertyName("deviceName")]
        public string DeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets estimated runtime in minutes.
        /// The estimated runtime of the device when the battery is fully charged. Unit in minutes. Valid values 0 to 2147483647
        /// </summary>
        [JsonPropertyName("estimatedRuntimeInMinutes")]
        public Int32? EstimatedRuntimeInMinutes { get; set; }
    
        /// <summary>
        /// Gets or sets full battery drain count.
        /// Number of times the battery has been discharged an amount that equals 100% of its capacity, but not necessarily by discharging it from 100% to 0%. Valid values 0 to 2147483647
        /// </summary>
        [JsonPropertyName("fullBatteryDrainCount")]
        public Int32? FullBatteryDrainCount { get; set; }
    
        /// <summary>
        /// Gets or sets health status.
        /// The overall battery health status of the device. Possible values are: unknown, insufficientData, needsAttention, meetingGoals, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("healthStatus")]
        public UserExperienceAnalyticsHealthState? HealthStatus { get; set; }
    
        /// <summary>
        /// Gets or sets manufacturer.
        /// The manufacturer name of the device.
        /// </summary>
        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }
    
        /// <summary>
        /// Gets or sets max capacity percentage.
        /// Ratio of current capacity and design capacity of the battery with the lowest capacity. Unit in percentage and values range from 0-100. Valid values 0 to 2147483647
        /// </summary>
        [JsonPropertyName("maxCapacityPercentage")]
        public Int32? MaxCapacityPercentage { get; set; }
    
        /// <summary>
        /// Gets or sets model.
        /// The model name of the device.
        /// </summary>
        [JsonPropertyName("model")]
        public string Model { get; set; }
    
    }
}

