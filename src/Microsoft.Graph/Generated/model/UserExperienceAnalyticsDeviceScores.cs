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
    /// The type User Experience Analytics Device Scores.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<UserExperienceAnalyticsDeviceScores>))]
    public partial class UserExperienceAnalyticsDeviceScores : Entity
    {
    
        /// <summary>
        /// Gets or sets app reliability score.
        /// Indicates a score calculated from application health data to indicate when a device is having problems running one or more applications. Valid values range from 0-100. Value -1 means associated score is unavailable. A higher score indicates a healthier device. Read-only. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
        /// </summary>
        [JsonPropertyName("appReliabilityScore")]
        public double? AppReliabilityScore { get; set; }
    
        /// <summary>
        /// Gets or sets battery health score.
        /// Indicates a calulated score indicating the health of the device's battery. Valid values range from 0-100. Value -1 means associated score is unavailable. A higher score indicates a healthier device. Read-only. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
        /// </summary>
        [JsonPropertyName("batteryHealthScore")]
        public double? BatteryHealthScore { get; set; }
    
        /// <summary>
        /// Gets or sets device name.
        /// The name of the device. Supports: $select, $OrderBy. Read-only.
        /// </summary>
        [JsonPropertyName("deviceName")]
        public string DeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets endpoint analytics score.
        /// Indicates a weighted average of the various scores. Valid values range from 0-100. Value -1 means associated score is unavailable. A higher score indicates a healthier device. Read-only. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
        /// </summary>
        [JsonPropertyName("endpointAnalyticsScore")]
        public double? EndpointAnalyticsScore { get; set; }
    
        /// <summary>
        /// Gets or sets health status.
        /// The health status of the device. Possible values are: unknown, insufficientData, needsAttention, meetingGoals. Unknown by default. Supports: $filter, $select, $OrderBy. Read-only. Possible values are: unknown, insufficientData, needsAttention, meetingGoals, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("healthStatus")]
        public UserExperienceAnalyticsHealthState? HealthStatus { get; set; }
    
        /// <summary>
        /// Gets or sets manufacturer.
        /// The manufacturer name of the device. Examples: Microsoft Corporation, HP, Lenovo. Supports: $select, $OrderBy. Read-only.
        /// </summary>
        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }
    
        /// <summary>
        /// Gets or sets model.
        /// The model name of the device. Supports: $select, $OrderBy. Read-only.
        /// </summary>
        [JsonPropertyName("model")]
        public string Model { get; set; }
    
        /// <summary>
        /// Gets or sets startup performance score.
        /// Indicates a weighted average of boot score and logon score used for measuring startup performance. Valid values range from 0-100. Value -1 means associated score is unavailable. A higher score indicates a healthier device. Read-only. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
        /// </summary>
        [JsonPropertyName("startupPerformanceScore")]
        public double? StartupPerformanceScore { get; set; }
    
        /// <summary>
        /// Gets or sets work from anywhere score.
        /// Indicates a weighted score of the work from anywhere on a device level. Valid values range from 0-100. Value -1 means associated score is unavailable. A higher score indicates a healthier device. Read-only. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
        /// </summary>
        [JsonPropertyName("workFromAnywhereScore")]
        public double? WorkFromAnywhereScore { get; set; }
    
    }
}

