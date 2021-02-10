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
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Device Management Autopilot Event.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceManagementAutopilotEvent : Entity
    {
    
		///<summary>
		/// The DeviceManagementAutopilotEvent constructor
		///</summary>
        public DeviceManagementAutopilotEvent()
        {
            this.ODataType = "microsoft.graph.deviceManagementAutopilotEvent";
        }
	
        /// <summary>
        /// Gets or sets account setup duration.
        /// Time spent in user ESP.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accountSetupDuration", Required = Newtonsoft.Json.Required.Default)]
        public Duration AccountSetupDuration { get; set; }
    
        /// <summary>
        /// Gets or sets account setup status.
        /// Deployment status for the enrollment status page account setup phase. Possible values are: unknown, success, inProgress, failure, successWithTimeout, notAttempted, disabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accountSetupStatus", Required = Newtonsoft.Json.Required.Default)]
        public WindowsAutopilotDeploymentState? AccountSetupStatus { get; set; }
    
        /// <summary>
        /// Gets or sets deployment duration.
        /// Autopilot deployment duration including enrollment.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deploymentDuration", Required = Newtonsoft.Json.Required.Default)]
        public Duration DeploymentDuration { get; set; }
    
        /// <summary>
        /// Gets or sets deployment end date time.
        /// Deployment end time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deploymentEndDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? DeploymentEndDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets deployment start date time.
        /// Deployment start time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deploymentStartDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? DeploymentStartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets deployment state.
        /// Deployment state like Success, Failure, InProgress, SuccessWithTimeout. Possible values are: unknown, success, inProgress, failure, successWithTimeout, notAttempted, disabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deploymentState", Required = Newtonsoft.Json.Required.Default)]
        public WindowsAutopilotDeploymentState? DeploymentState { get; set; }
    
        /// <summary>
        /// Gets or sets deployment total duration.
        /// Total deployment duration from enrollment to Desktop screen.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deploymentTotalDuration", Required = Newtonsoft.Json.Required.Default)]
        public Duration DeploymentTotalDuration { get; set; }
    
        /// <summary>
        /// Gets or sets device id.
        /// Device id associated with the object
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceId", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets device preparation duration.
        /// Time spent in device enrollment.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "devicePreparationDuration", Required = Newtonsoft.Json.Required.Default)]
        public Duration DevicePreparationDuration { get; set; }
    
        /// <summary>
        /// Gets or sets device registered date time.
        /// Device registration date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceRegisteredDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? DeviceRegisteredDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets device serial number.
        /// Device serial number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceSerialNumber", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceSerialNumber { get; set; }
    
        /// <summary>
        /// Gets or sets device setup duration.
        /// Time spent in device ESP.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceSetupDuration", Required = Newtonsoft.Json.Required.Default)]
        public Duration DeviceSetupDuration { get; set; }
    
        /// <summary>
        /// Gets or sets device setup status.
        /// Deployment status for the enrollment status page device setup phase. Possible values are: unknown, success, inProgress, failure, successWithTimeout, notAttempted, disabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceSetupStatus", Required = Newtonsoft.Json.Required.Default)]
        public WindowsAutopilotDeploymentState? DeviceSetupStatus { get; set; }
    
        /// <summary>
        /// Gets or sets enrollment failure details.
        /// Enrollment failure details.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enrollmentFailureDetails", Required = Newtonsoft.Json.Required.Default)]
        public string EnrollmentFailureDetails { get; set; }
    
        /// <summary>
        /// Gets or sets enrollment start date time.
        /// Device enrollment start date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enrollmentStartDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? EnrollmentStartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets enrollment state.
        /// Enrollment state like Enrolled, Failed. Possible values are: unknown, enrolled, pendingReset, failed, notContacted, blocked.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enrollmentState", Required = Newtonsoft.Json.Required.Default)]
        public EnrollmentState? EnrollmentState { get; set; }
    
        /// <summary>
        /// Gets or sets enrollment type.
        /// Enrollment type. Possible values are: unknown, azureADJoinedWithAutopilotProfile, offlineDomainJoined, azureADJoinedUsingDeviceAuthWithAutopilotProfile, azureADJoinedUsingDeviceAuthWithoutAutopilotProfile, azureADJoinedWithOfflineAutopilotProfile, azureADJoinedWithWhiteGlove, offlineDomainJoinedWithWhiteGlove, offlineDomainJoinedWithOfflineAutopilotProfile.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enrollmentType", Required = Newtonsoft.Json.Required.Default)]
        public WindowsAutopilotEnrollmentType? EnrollmentType { get; set; }
    
        /// <summary>
        /// Gets or sets event date time.
        /// Time when the event occurred .
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "eventDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? EventDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets managed device name.
        /// Managed device name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedDeviceName", Required = Newtonsoft.Json.Required.Default)]
        public string ManagedDeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets os version.
        /// Device operating system version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "osVersion", Required = Newtonsoft.Json.Required.Default)]
        public string OsVersion { get; set; }
    
        /// <summary>
        /// Gets or sets targeted app count.
        /// Count of applications targeted.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "targetedAppCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? TargetedAppCount { get; set; }
    
        /// <summary>
        /// Gets or sets targeted policy count.
        /// Count of policies targeted.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "targetedPolicyCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? TargetedPolicyCount { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// User principal name used to enroll the device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets windows10enrollment completion page configuration display name.
        /// Enrollment Status Page profile name
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windows10EnrollmentCompletionPageConfigurationDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string Windows10EnrollmentCompletionPageConfigurationDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets windows10enrollment completion page configuration id.
        /// Enrollment Status Page profile ID
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windows10EnrollmentCompletionPageConfigurationId", Required = Newtonsoft.Json.Required.Default)]
        public string Windows10EnrollmentCompletionPageConfigurationId { get; set; }
    
        /// <summary>
        /// Gets or sets windows autopilot deployment profile display name.
        /// Autopilot profile name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windowsAutopilotDeploymentProfileDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string WindowsAutopilotDeploymentProfileDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets policy status details.
        /// Policy and application status details for this device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "policyStatusDetails", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementAutopilotEventPolicyStatusDetailsCollectionPage PolicyStatusDetails { get; set; }
    
    }
}

