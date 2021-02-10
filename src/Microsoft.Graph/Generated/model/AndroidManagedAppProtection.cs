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
    /// The type Android Managed App Protection.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AndroidManagedAppProtection : TargetedManagedAppProtection
    {
    
		///<summary>
		/// The AndroidManagedAppProtection constructor
		///</summary>
        public AndroidManagedAppProtection()
        {
            this.ODataType = "microsoft.graph.androidManagedAppProtection";
        }
	
        /// <summary>
        /// Gets or sets allowed android device manufacturers.
        /// Semicolon seperated list of device manufacturers allowed, as a string, for the managed app to work.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowedAndroidDeviceManufacturers", Required = Newtonsoft.Json.Required.Default)]
        public string AllowedAndroidDeviceManufacturers { get; set; }
    
        /// <summary>
        /// Gets or sets allowed android device models.
        /// List of device models allowed, as a string, for the managed app to work.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowedAndroidDeviceModels", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> AllowedAndroidDeviceModels { get; set; }
    
        /// <summary>
        /// Gets or sets app action if android device manufacturer not allowed.
        /// Defines a managed app behavior, either block or wipe, if the specified device manufacturer is not allowed. Possible values are: block, wipe, warn.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appActionIfAndroidDeviceManufacturerNotAllowed", Required = Newtonsoft.Json.Required.Default)]
        public ManagedAppRemediationAction? AppActionIfAndroidDeviceManufacturerNotAllowed { get; set; }
    
        /// <summary>
        /// Gets or sets app action if android device model not allowed.
        /// Defines a managed app behavior, either block or wipe, if the specified device model is not allowed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appActionIfAndroidDeviceModelNotAllowed", Required = Newtonsoft.Json.Required.Default)]
        public ManagedAppRemediationAction? AppActionIfAndroidDeviceModelNotAllowed { get; set; }
    
        /// <summary>
        /// Gets or sets app action if android safety net apps verification failed.
        /// Defines a managed app behavior, either warn or block, if the specified Android App Verification requirement fails. Possible values are: block, wipe, warn.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appActionIfAndroidSafetyNetAppsVerificationFailed", Required = Newtonsoft.Json.Required.Default)]
        public ManagedAppRemediationAction? AppActionIfAndroidSafetyNetAppsVerificationFailed { get; set; }
    
        /// <summary>
        /// Gets or sets app action if android safety net device attestation failed.
        /// Defines a managed app behavior, either warn or block, if the specified Android SafetyNet Attestation requirement fails. Possible values are: block, wipe, warn.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appActionIfAndroidSafetyNetDeviceAttestationFailed", Required = Newtonsoft.Json.Required.Default)]
        public ManagedAppRemediationAction? AppActionIfAndroidSafetyNetDeviceAttestationFailed { get; set; }
    
        /// <summary>
        /// Gets or sets app action if device lock not set.
        /// Defines a managed app behavior, either warn, block or wipe, if the screen lock is required on android device but is not set.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appActionIfDeviceLockNotSet", Required = Newtonsoft.Json.Required.Default)]
        public ManagedAppRemediationAction? AppActionIfDeviceLockNotSet { get; set; }
    
        /// <summary>
        /// Gets or sets approved keyboards.
        /// If Keyboard Restriction is enabled, only keyboards in this approved list will be allowed. A key should be Android package id for a keyboard and value should be a friendly name
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "approvedKeyboards", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<KeyValuePair> ApprovedKeyboards { get; set; }
    
        /// <summary>
        /// Gets or sets biometric authentication blocked.
        /// Indicates whether use of the biometric authentication is allowed in place of a pin if PinRequired is set to True.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "biometricAuthenticationBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? BiometricAuthenticationBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets block after company portal update deferral in days.
        /// Maximum number of days Company Portal update can be deferred on the device or app access will be blocked.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "blockAfterCompanyPortalUpdateDeferralInDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? BlockAfterCompanyPortalUpdateDeferralInDays { get; set; }
    
        /// <summary>
        /// Gets or sets custom browser display name.
        /// Friendly name of the preferred custom browser to open weblink on Android.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customBrowserDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string CustomBrowserDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets custom browser package id.
        /// Unique identifier of a custom browser to open weblink on Android.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customBrowserPackageId", Required = Newtonsoft.Json.Required.Default)]
        public string CustomBrowserPackageId { get; set; }
    
        /// <summary>
        /// Gets or sets custom dialer app display name.
        /// Friendly name of a custom dialer app to click-to-open a phone number on Android.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customDialerAppDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string CustomDialerAppDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets custom dialer app package id.
        /// PackageId of a custom dialer app to click-to-open a phone number on Android.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customDialerAppPackageId", Required = Newtonsoft.Json.Required.Default)]
        public string CustomDialerAppPackageId { get; set; }
    
        /// <summary>
        /// Gets or sets deployed app count.
        /// Count of apps to which the current policy is deployed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deployedAppCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? DeployedAppCount { get; set; }
    
        /// <summary>
        /// Gets or sets device lock required.
        /// Defines if any kind of lock must be required on android device
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceLockRequired", Required = Newtonsoft.Json.Required.Default)]
        public bool? DeviceLockRequired { get; set; }
    
        /// <summary>
        /// Gets or sets disable app encryption if device encryption is enabled.
        /// When this setting is enabled, app level encryption is disabled if device level encryption is enabled
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "disableAppEncryptionIfDeviceEncryptionIsEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? DisableAppEncryptionIfDeviceEncryptionIsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets encrypt app data.
        /// Indicates whether application data for managed apps should be encrypted
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "encryptAppData", Required = Newtonsoft.Json.Required.Default)]
        public bool? EncryptAppData { get; set; }
    
        /// <summary>
        /// Gets or sets exempted app packages.
        /// App packages in this list will be exempt from the policy and will be able to receive data from managed apps.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exemptedAppPackages", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<KeyValuePair> ExemptedAppPackages { get; set; }
    
        /// <summary>
        /// Gets or sets keyboards restricted.
        /// Indicates if keyboard restriction is enabled. If enabled list of approved keyboards must be provided as well.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "keyboardsRestricted", Required = Newtonsoft.Json.Required.Default)]
        public bool? KeyboardsRestricted { get; set; }
    
        /// <summary>
        /// Gets or sets minimum required company portal version.
        /// Minimum version of the Company portal that must be installed on the device or app access will be blocked
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimumRequiredCompanyPortalVersion", Required = Newtonsoft.Json.Required.Default)]
        public string MinimumRequiredCompanyPortalVersion { get; set; }
    
        /// <summary>
        /// Gets or sets minimum required patch version.
        /// Define the oldest required Android security patch level a user can have to gain secure access to the app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimumRequiredPatchVersion", Required = Newtonsoft.Json.Required.Default)]
        public string MinimumRequiredPatchVersion { get; set; }
    
        /// <summary>
        /// Gets or sets minimum warning company portal version.
        /// Minimum version of the Company portal that must be installed on the device or the user will receive a warning
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimumWarningCompanyPortalVersion", Required = Newtonsoft.Json.Required.Default)]
        public string MinimumWarningCompanyPortalVersion { get; set; }
    
        /// <summary>
        /// Gets or sets minimum warning patch version.
        /// Define the oldest recommended Android security patch level a user can have for secure access to the app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimumWarningPatchVersion", Required = Newtonsoft.Json.Required.Default)]
        public string MinimumWarningPatchVersion { get; set; }
    
        /// <summary>
        /// Gets or sets minimum wipe company portal version.
        /// Minimum version of the Company portal that must be installed on the device or the company data on the app will be wiped
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimumWipeCompanyPortalVersion", Required = Newtonsoft.Json.Required.Default)]
        public string MinimumWipeCompanyPortalVersion { get; set; }
    
        /// <summary>
        /// Gets or sets minimum wipe patch version.
        /// Android security patch level  less than or equal to the specified value will wipe the managed app and the associated company data.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimumWipePatchVersion", Required = Newtonsoft.Json.Required.Default)]
        public string MinimumWipePatchVersion { get; set; }
    
        /// <summary>
        /// Gets or sets required android safety net apps verification type.
        /// Defines the Android SafetyNet Apps Verification requirement for a managed app to work. Possible values are: none, enabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "requiredAndroidSafetyNetAppsVerificationType", Required = Newtonsoft.Json.Required.Default)]
        public AndroidManagedAppSafetyNetAppsVerificationType? RequiredAndroidSafetyNetAppsVerificationType { get; set; }
    
        /// <summary>
        /// Gets or sets required android safety net device attestation type.
        /// Defines the Android SafetyNet Device Attestation requirement for a managed app to work. Possible values are: none, basicIntegrity, basicIntegrityAndDeviceCertification.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "requiredAndroidSafetyNetDeviceAttestationType", Required = Newtonsoft.Json.Required.Default)]
        public AndroidManagedAppSafetyNetDeviceAttestationType? RequiredAndroidSafetyNetDeviceAttestationType { get; set; }
    
        /// <summary>
        /// Gets or sets required android safety net evaluation type.
        /// Defines the Android SafetyNet evaluation type requirement for a managed app to work.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "requiredAndroidSafetyNetEvaluationType", Required = Newtonsoft.Json.Required.Default)]
        public AndroidManagedAppSafetyNetEvaluationType? RequiredAndroidSafetyNetEvaluationType { get; set; }
    
        /// <summary>
        /// Gets or sets screen capture blocked.
        /// Indicates whether a managed user can take screen captures of managed apps
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "screenCaptureBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? ScreenCaptureBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets warn after company portal update deferral in days.
        /// Maximum number of days Company Portal update can be deferred on the device or the user will receive the warning
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "warnAfterCompanyPortalUpdateDeferralInDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? WarnAfterCompanyPortalUpdateDeferralInDays { get; set; }
    
        /// <summary>
        /// Gets or sets wipe after company portal update deferral in days.
        /// Maximum number of days Company Portal update can be deferred on the device or the company data on the app will be wiped
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "wipeAfterCompanyPortalUpdateDeferralInDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? WipeAfterCompanyPortalUpdateDeferralInDays { get; set; }
    
        /// <summary>
        /// Gets or sets apps.
        /// List of apps to which the policy is deployed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "apps", Required = Newtonsoft.Json.Required.Default)]
        public IAndroidManagedAppProtectionAppsCollectionPage Apps { get; set; }
    
        /// <summary>
        /// Gets or sets deployment summary.
        /// Navigation property to deployment summary of the configuration.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deploymentSummary", Required = Newtonsoft.Json.Required.Default)]
        public ManagedAppPolicyDeploymentSummary DeploymentSummary { get; set; }
    
    }
}

