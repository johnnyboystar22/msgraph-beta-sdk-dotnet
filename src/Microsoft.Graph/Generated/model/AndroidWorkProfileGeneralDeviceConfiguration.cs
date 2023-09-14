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
    /// The type Android Work Profile General Device Configuration.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AndroidWorkProfileGeneralDeviceConfiguration>))]
    public partial class AndroidWorkProfileGeneralDeviceConfiguration : DeviceConfiguration
    {
    
        ///<summary>
        /// The AndroidWorkProfileGeneralDeviceConfiguration constructor
        ///</summary>
        public AndroidWorkProfileGeneralDeviceConfiguration()
        {
            this.ODataType = "microsoft.graph.androidWorkProfileGeneralDeviceConfiguration";
        }

        /// <summary>
        /// Gets or sets allowed google account domains.
        /// Determine domains allow-list for accounts that can be added to work profile.
        /// </summary>
        [JsonPropertyName("allowedGoogleAccountDomains")]
        public IEnumerable<string> AllowedGoogleAccountDomains { get; set; }
    
        /// <summary>
        /// Gets or sets block unified password for work profile.
        /// Prevent using unified password for unlocking device and work profile.
        /// </summary>
        [JsonPropertyName("blockUnifiedPasswordForWorkProfile")]
        public bool? BlockUnifiedPasswordForWorkProfile { get; set; }
    
        /// <summary>
        /// Gets or sets password block face unlock.
        /// Indicates whether or not to block face unlock.
        /// </summary>
        [JsonPropertyName("passwordBlockFaceUnlock")]
        public bool? PasswordBlockFaceUnlock { get; set; }
    
        /// <summary>
        /// Gets or sets password block fingerprint unlock.
        /// Indicates whether or not to block fingerprint unlock.
        /// </summary>
        [JsonPropertyName("passwordBlockFingerprintUnlock")]
        public bool? PasswordBlockFingerprintUnlock { get; set; }
    
        /// <summary>
        /// Gets or sets password block iris unlock.
        /// Indicates whether or not to block iris unlock.
        /// </summary>
        [JsonPropertyName("passwordBlockIrisUnlock")]
        public bool? PasswordBlockIrisUnlock { get; set; }
    
        /// <summary>
        /// Gets or sets password block trust agents.
        /// Indicates whether or not to block Smart Lock and other trust agents.
        /// </summary>
        [JsonPropertyName("passwordBlockTrustAgents")]
        public bool? PasswordBlockTrustAgents { get; set; }
    
        /// <summary>
        /// Gets or sets password expiration days.
        /// Number of days before the password expires. Valid values 1 to 365
        /// </summary>
        [JsonPropertyName("passwordExpirationDays")]
        public Int32? PasswordExpirationDays { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum length.
        /// Minimum length of passwords. Valid values 4 to 16
        /// </summary>
        [JsonPropertyName("passwordMinimumLength")]
        public Int32? PasswordMinimumLength { get; set; }
    
        /// <summary>
        /// Gets or sets password minutes of inactivity before screen timeout.
        /// Minutes of inactivity before the screen times out.
        /// </summary>
        [JsonPropertyName("passwordMinutesOfInactivityBeforeScreenTimeout")]
        public Int32? PasswordMinutesOfInactivityBeforeScreenTimeout { get; set; }
    
        /// <summary>
        /// Gets or sets password previous password block count.
        /// Number of previous passwords to block. Valid values 0 to 24
        /// </summary>
        [JsonPropertyName("passwordPreviousPasswordBlockCount")]
        public Int32? PasswordPreviousPasswordBlockCount { get; set; }
    
        /// <summary>
        /// Gets or sets password required type.
        /// Type of password that is required. Possible values are: deviceDefault, lowSecurityBiometric, required, atLeastNumeric, numericComplex, atLeastAlphabetic, atLeastAlphanumeric, alphanumericWithSymbols.
        /// </summary>
        [JsonPropertyName("passwordRequiredType")]
        public AndroidWorkProfileRequiredPasswordType? PasswordRequiredType { get; set; }
    
        /// <summary>
        /// Gets or sets password sign in failure count before factory reset.
        /// Number of sign in failures allowed before factory reset. Valid values 1 to 16
        /// </summary>
        [JsonPropertyName("passwordSignInFailureCountBeforeFactoryReset")]
        public Int32? PasswordSignInFailureCountBeforeFactoryReset { get; set; }
    
        /// <summary>
        /// Gets or sets required password complexity.
        /// Indicates the required device password complexity on Android. One of: NONE, LOW, MEDIUM, HIGH. This is a new API targeted to Android 12+. Possible values are: none, low, medium, high.
        /// </summary>
        [JsonPropertyName("requiredPasswordComplexity")]
        public AndroidRequiredPasswordComplexity? RequiredPasswordComplexity { get; set; }
    
        /// <summary>
        /// Gets or sets security require verify apps.
        /// Require the Android Verify apps feature is turned on.
        /// </summary>
        [JsonPropertyName("securityRequireVerifyApps")]
        public bool? SecurityRequireVerifyApps { get; set; }
    
        /// <summary>
        /// Gets or sets vpn always on package identifier.
        /// Enable lockdown mode for always-on VPN.
        /// </summary>
        [JsonPropertyName("vpnAlwaysOnPackageIdentifier")]
        public string VpnAlwaysOnPackageIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets vpn enable always on lockdown mode.
        /// Enable lockdown mode for always-on VPN.
        /// </summary>
        [JsonPropertyName("vpnEnableAlwaysOnLockdownMode")]
        public bool? VpnEnableAlwaysOnLockdownMode { get; set; }
    
        /// <summary>
        /// Gets or sets work profile account use.
        /// Control user's ability to add accounts in work profile including Google accounts. Possible values are: allowAllExceptGoogleAccounts, blockAll, allowAll, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("workProfileAccountUse")]
        public AndroidWorkProfileAccountUse? WorkProfileAccountUse { get; set; }
    
        /// <summary>
        /// Gets or sets work profile allow app installs from unknown sources.
        /// Indicates whether to allow installation of apps from unknown sources.
        /// </summary>
        [JsonPropertyName("workProfileAllowAppInstallsFromUnknownSources")]
        public bool? WorkProfileAllowAppInstallsFromUnknownSources { get; set; }
    
        /// <summary>
        /// Gets or sets work profile allow widgets.
        /// Allow widgets from work profile apps.
        /// </summary>
        [JsonPropertyName("workProfileAllowWidgets")]
        public bool? WorkProfileAllowWidgets { get; set; }
    
        /// <summary>
        /// Gets or sets work profile block adding accounts.
        /// Block users from adding/removing accounts in work profile.
        /// </summary>
        [JsonPropertyName("workProfileBlockAddingAccounts")]
        public bool? WorkProfileBlockAddingAccounts { get; set; }
    
        /// <summary>
        /// Gets or sets work profile block camera.
        /// Block work profile camera.
        /// </summary>
        [JsonPropertyName("workProfileBlockCamera")]
        public bool? WorkProfileBlockCamera { get; set; }
    
        /// <summary>
        /// Gets or sets work profile block cross profile caller id.
        /// Block display work profile caller ID in personal profile.
        /// </summary>
        [JsonPropertyName("workProfileBlockCrossProfileCallerId")]
        public bool? WorkProfileBlockCrossProfileCallerId { get; set; }
    
        /// <summary>
        /// Gets or sets work profile block cross profile contacts search.
        /// Block work profile contacts availability in personal profile.
        /// </summary>
        [JsonPropertyName("workProfileBlockCrossProfileContactsSearch")]
        public bool? WorkProfileBlockCrossProfileContactsSearch { get; set; }
    
        /// <summary>
        /// Gets or sets work profile block cross profile copy paste.
        /// Boolean that indicates if the setting disallow cross profile copy/paste is enabled.
        /// </summary>
        [JsonPropertyName("workProfileBlockCrossProfileCopyPaste")]
        public bool? WorkProfileBlockCrossProfileCopyPaste { get; set; }
    
        /// <summary>
        /// Gets or sets work profile block notifications while device locked.
        /// Indicates whether or not to block notifications while device locked.
        /// </summary>
        [JsonPropertyName("workProfileBlockNotificationsWhileDeviceLocked")]
        public bool? WorkProfileBlockNotificationsWhileDeviceLocked { get; set; }
    
        /// <summary>
        /// Gets or sets work profile block personal app installs from unknown sources.
        /// Prevent app installations from unknown sources in the personal profile.
        /// </summary>
        [JsonPropertyName("workProfileBlockPersonalAppInstallsFromUnknownSources")]
        public bool? WorkProfileBlockPersonalAppInstallsFromUnknownSources { get; set; }
    
        /// <summary>
        /// Gets or sets work profile block screen capture.
        /// Block screen capture in work profile.
        /// </summary>
        [JsonPropertyName("workProfileBlockScreenCapture")]
        public bool? WorkProfileBlockScreenCapture { get; set; }
    
        /// <summary>
        /// Gets or sets work profile bluetooth enable contact sharing.
        /// Allow bluetooth devices to access enterprise contacts.
        /// </summary>
        [JsonPropertyName("workProfileBluetoothEnableContactSharing")]
        public bool? WorkProfileBluetoothEnableContactSharing { get; set; }
    
        /// <summary>
        /// Gets or sets work profile data sharing type.
        /// Type of data sharing that is allowed. Possible values are: deviceDefault, preventAny, allowPersonalToWork, noRestrictions.
        /// </summary>
        [JsonPropertyName("workProfileDataSharingType")]
        public AndroidWorkProfileCrossProfileDataSharingType? WorkProfileDataSharingType { get; set; }
    
        /// <summary>
        /// Gets or sets work profile default app permission policy.
        /// Type of password that is required. Possible values are: deviceDefault, prompt, autoGrant, autoDeny.
        /// </summary>
        [JsonPropertyName("workProfileDefaultAppPermissionPolicy")]
        public AndroidWorkProfileDefaultAppPermissionPolicyType? WorkProfileDefaultAppPermissionPolicy { get; set; }
    
        /// <summary>
        /// Gets or sets work profile password block face unlock.
        /// Indicates whether or not to block face unlock for work profile.
        /// </summary>
        [JsonPropertyName("workProfilePasswordBlockFaceUnlock")]
        public bool? WorkProfilePasswordBlockFaceUnlock { get; set; }
    
        /// <summary>
        /// Gets or sets work profile password block fingerprint unlock.
        /// Indicates whether or not to block fingerprint unlock for work profile.
        /// </summary>
        [JsonPropertyName("workProfilePasswordBlockFingerprintUnlock")]
        public bool? WorkProfilePasswordBlockFingerprintUnlock { get; set; }
    
        /// <summary>
        /// Gets or sets work profile password block iris unlock.
        /// Indicates whether or not to block iris unlock for work profile.
        /// </summary>
        [JsonPropertyName("workProfilePasswordBlockIrisUnlock")]
        public bool? WorkProfilePasswordBlockIrisUnlock { get; set; }
    
        /// <summary>
        /// Gets or sets work profile password block trust agents.
        /// Indicates whether or not to block Smart Lock and other trust agents for work profile.
        /// </summary>
        [JsonPropertyName("workProfilePasswordBlockTrustAgents")]
        public bool? WorkProfilePasswordBlockTrustAgents { get; set; }
    
        /// <summary>
        /// Gets or sets work profile password expiration days.
        /// Number of days before the work profile password expires. Valid values 1 to 365
        /// </summary>
        [JsonPropertyName("workProfilePasswordExpirationDays")]
        public Int32? WorkProfilePasswordExpirationDays { get; set; }
    
        /// <summary>
        /// Gets or sets work profile password minimum length.
        /// Minimum length of work profile password. Valid values 4 to 16
        /// </summary>
        [JsonPropertyName("workProfilePasswordMinimumLength")]
        public Int32? WorkProfilePasswordMinimumLength { get; set; }
    
        /// <summary>
        /// Gets or sets work profile password min letter characters.
        /// Minimum # of letter characters required in work profile password. Valid values 1 to 10
        /// </summary>
        [JsonPropertyName("workProfilePasswordMinLetterCharacters")]
        public Int32? WorkProfilePasswordMinLetterCharacters { get; set; }
    
        /// <summary>
        /// Gets or sets work profile password min lower case characters.
        /// Minimum # of lower-case characters required in work profile password. Valid values 1 to 10
        /// </summary>
        [JsonPropertyName("workProfilePasswordMinLowerCaseCharacters")]
        public Int32? WorkProfilePasswordMinLowerCaseCharacters { get; set; }
    
        /// <summary>
        /// Gets or sets work profile password min non letter characters.
        /// Minimum # of non-letter characters required in work profile password. Valid values 1 to 10
        /// </summary>
        [JsonPropertyName("workProfilePasswordMinNonLetterCharacters")]
        public Int32? WorkProfilePasswordMinNonLetterCharacters { get; set; }
    
        /// <summary>
        /// Gets or sets work profile password min numeric characters.
        /// Minimum # of numeric characters required in work profile password. Valid values 1 to 10
        /// </summary>
        [JsonPropertyName("workProfilePasswordMinNumericCharacters")]
        public Int32? WorkProfilePasswordMinNumericCharacters { get; set; }
    
        /// <summary>
        /// Gets or sets work profile password min symbol characters.
        /// Minimum # of symbols required in work profile password. Valid values 1 to 10
        /// </summary>
        [JsonPropertyName("workProfilePasswordMinSymbolCharacters")]
        public Int32? WorkProfilePasswordMinSymbolCharacters { get; set; }
    
        /// <summary>
        /// Gets or sets work profile password min upper case characters.
        /// Minimum # of upper-case characters required in work profile password. Valid values 1 to 10
        /// </summary>
        [JsonPropertyName("workProfilePasswordMinUpperCaseCharacters")]
        public Int32? WorkProfilePasswordMinUpperCaseCharacters { get; set; }
    
        /// <summary>
        /// Gets or sets work profile password minutes of inactivity before screen timeout.
        /// Minutes of inactivity before the screen times out.
        /// </summary>
        [JsonPropertyName("workProfilePasswordMinutesOfInactivityBeforeScreenTimeout")]
        public Int32? WorkProfilePasswordMinutesOfInactivityBeforeScreenTimeout { get; set; }
    
        /// <summary>
        /// Gets or sets work profile password previous password block count.
        /// Number of previous work profile passwords to block. Valid values 0 to 24
        /// </summary>
        [JsonPropertyName("workProfilePasswordPreviousPasswordBlockCount")]
        public Int32? WorkProfilePasswordPreviousPasswordBlockCount { get; set; }
    
        /// <summary>
        /// Gets or sets work profile password required type.
        /// Type of work profile password that is required. Possible values are: deviceDefault, lowSecurityBiometric, required, atLeastNumeric, numericComplex, atLeastAlphabetic, atLeastAlphanumeric, alphanumericWithSymbols.
        /// </summary>
        [JsonPropertyName("workProfilePasswordRequiredType")]
        public AndroidWorkProfileRequiredPasswordType? WorkProfilePasswordRequiredType { get; set; }
    
        /// <summary>
        /// Gets or sets work profile password sign in failure count before factory reset.
        /// Number of sign in failures allowed before work profile is removed and all corporate data deleted. Valid values 1 to 16
        /// </summary>
        [JsonPropertyName("workProfilePasswordSignInFailureCountBeforeFactoryReset")]
        public Int32? WorkProfilePasswordSignInFailureCountBeforeFactoryReset { get; set; }
    
        /// <summary>
        /// Gets or sets work profile required password complexity.
        /// Indicates the required work profile password complexity on Android. One of: NONE, LOW, MEDIUM, HIGH. This is a new API targeted to Android 12+. Possible values are: none, low, medium, high.
        /// </summary>
        [JsonPropertyName("workProfileRequiredPasswordComplexity")]
        public AndroidRequiredPasswordComplexity? WorkProfileRequiredPasswordComplexity { get; set; }
    
        /// <summary>
        /// Gets or sets work profile require password.
        /// Password is required or not for work profile
        /// </summary>
        [JsonPropertyName("workProfileRequirePassword")]
        public bool? WorkProfileRequirePassword { get; set; }
    
    }
}

