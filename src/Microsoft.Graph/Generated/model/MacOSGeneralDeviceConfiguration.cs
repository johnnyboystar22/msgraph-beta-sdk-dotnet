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
    /// The type Mac OSGeneral Device Configuration.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<MacOSGeneralDeviceConfiguration>))]
    public partial class MacOSGeneralDeviceConfiguration : DeviceConfiguration
    {
    
        ///<summary>
        /// The MacOSGeneralDeviceConfiguration constructor
        ///</summary>
        public MacOSGeneralDeviceConfiguration()
        {
            this.ODataType = "microsoft.graph.macOSGeneralDeviceConfiguration";
        }

        /// <summary>
        /// Gets or sets activation lock when supervised allowed.
        /// When TRUE, activation lock is allowed when the devices is in the supervised mode. When FALSE, activation lock is not allowed. Default is false.
        /// </summary>
        [JsonPropertyName("activationLockWhenSupervisedAllowed")]
        public bool? ActivationLockWhenSupervisedAllowed { get; set; }
    
        /// <summary>
        /// Gets or sets adding game center friends blocked.
        /// Yes prevents users from adding friends to Game Center. Available for devices running macOS versions 10.13 and later.
        /// </summary>
        [JsonPropertyName("addingGameCenterFriendsBlocked")]
        public bool? AddingGameCenterFriendsBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets air drop blocked.
        /// Indicates whether or not to allow AirDrop.
        /// </summary>
        [JsonPropertyName("airDropBlocked")]
        public bool? AirDropBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets apple watch block auto unlock.
        /// Indicates whether or to block users from unlocking their Mac with Apple Watch.
        /// </summary>
        [JsonPropertyName("appleWatchBlockAutoUnlock")]
        public bool? AppleWatchBlockAutoUnlock { get; set; }
    
        /// <summary>
        /// Gets or sets camera blocked.
        /// Indicates whether or not to block the user from accessing the camera of the device.
        /// </summary>
        [JsonPropertyName("cameraBlocked")]
        public bool? CameraBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets classroom app block remote screen observation.
        /// Indicates whether or not to allow remote screen observation by Classroom app. Requires MDM enrollment via Apple School Manager or Apple Business Manager.
        /// </summary>
        [JsonPropertyName("classroomAppBlockRemoteScreenObservation")]
        public bool? ClassroomAppBlockRemoteScreenObservation { get; set; }
    
        /// <summary>
        /// Gets or sets classroom app force unprompted screen observation.
        /// Indicates whether or not to automatically give permission to the teacher of a managed course on the Classroom app to view a student's screen without prompting. Requires MDM enrollment via Apple School Manager or Apple Business Manager.
        /// </summary>
        [JsonPropertyName("classroomAppForceUnpromptedScreenObservation")]
        public bool? ClassroomAppForceUnpromptedScreenObservation { get; set; }
    
        /// <summary>
        /// Gets or sets classroom force automatically join classes.
        /// Indicates whether or not to automatically give permission to the teacher's requests, without prompting the student. Requires MDM enrollment via Apple School Manager or Apple Business Manager.
        /// </summary>
        [JsonPropertyName("classroomForceAutomaticallyJoinClasses")]
        public bool? ClassroomForceAutomaticallyJoinClasses { get; set; }
    
        /// <summary>
        /// Gets or sets classroom force request permission to leave classes.
        /// Indicates whether a student enrolled in an unmanaged course via Classroom will be required to request permission from the teacher when attempting to leave the course. Requires MDM enrollment via Apple School Manager or Apple Business Manager.
        /// </summary>
        [JsonPropertyName("classroomForceRequestPermissionToLeaveClasses")]
        public bool? ClassroomForceRequestPermissionToLeaveClasses { get; set; }
    
        /// <summary>
        /// Gets or sets classroom force unprompted app and device lock.
        /// Indicates whether or not to allow the teacher to lock apps or the device without prompting the student. Requires MDM enrollment via Apple School Manager or Apple Business Manager.
        /// </summary>
        [JsonPropertyName("classroomForceUnpromptedAppAndDeviceLock")]
        public bool? ClassroomForceUnpromptedAppAndDeviceLock { get; set; }
    
        /// <summary>
        /// Gets or sets compliant app list type.
        /// List that is in the CompliantAppsList. Possible values are: none, appsInListCompliant, appsNotInListCompliant.
        /// </summary>
        [JsonPropertyName("compliantAppListType")]
        public AppListType? CompliantAppListType { get; set; }
    
        /// <summary>
        /// Gets or sets compliant apps list.
        /// List of apps in the compliance (either allow list or block list, controlled by CompliantAppListType). This collection can contain a maximum of 10000 elements.
        /// </summary>
        [JsonPropertyName("compliantAppsList")]
        public IEnumerable<AppListItem> CompliantAppsList { get; set; }
    
        /// <summary>
        /// Gets or sets content caching blocked.
        /// Indicates whether or not to allow content caching.
        /// </summary>
        [JsonPropertyName("contentCachingBlocked")]
        public bool? ContentCachingBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets definition lookup blocked.
        /// Indicates whether or not to block definition lookup.
        /// </summary>
        [JsonPropertyName("definitionLookupBlocked")]
        public bool? DefinitionLookupBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets email in domain suffixes.
        /// An email address lacking a suffix that matches any of these strings will be considered out-of-domain.
        /// </summary>
        [JsonPropertyName("emailInDomainSuffixes")]
        public IEnumerable<string> EmailInDomainSuffixes { get; set; }
    
        /// <summary>
        /// Gets or sets erase content and settings blocked.
        /// TRUE disables the reset option on supervised devices. FALSE enables the reset option on supervised devices. Available for devices running macOS versions 12.0 and later.
        /// </summary>
        [JsonPropertyName("eraseContentAndSettingsBlocked")]
        public bool? EraseContentAndSettingsBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets game center blocked.
        /// Yes disables Game Center, and the Game Center icon is removed from the Home screen. Available for devices running macOS versions 10.13 and later.
        /// </summary>
        [JsonPropertyName("gameCenterBlocked")]
        public bool? GameCenterBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets i cloud block activity continuation.
        /// Indicates whether or not to block the user from continuing work that they started on a MacOS device on another iOS or MacOS device (MacOS 10.15 or later).
        /// </summary>
        [JsonPropertyName("iCloudBlockActivityContinuation")]
        public bool? ICloudBlockActivityContinuation { get; set; }
    
        /// <summary>
        /// Gets or sets i cloud block address book.
        /// Indicates whether or not to block iCloud from syncing contacts.
        /// </summary>
        [JsonPropertyName("iCloudBlockAddressBook")]
        public bool? ICloudBlockAddressBook { get; set; }
    
        /// <summary>
        /// Gets or sets i cloud block bookmarks.
        /// Indicates whether or not to block iCloud from syncing bookmarks.
        /// </summary>
        [JsonPropertyName("iCloudBlockBookmarks")]
        public bool? ICloudBlockBookmarks { get; set; }
    
        /// <summary>
        /// Gets or sets i cloud block calendar.
        /// Indicates whether or not to block iCloud from syncing calendars.
        /// </summary>
        [JsonPropertyName("iCloudBlockCalendar")]
        public bool? ICloudBlockCalendar { get; set; }
    
        /// <summary>
        /// Gets or sets i cloud block document sync.
        /// Indicates whether or not to block iCloud document sync.
        /// </summary>
        [JsonPropertyName("iCloudBlockDocumentSync")]
        public bool? ICloudBlockDocumentSync { get; set; }
    
        /// <summary>
        /// Gets or sets i cloud block mail.
        /// Indicates whether or not to block iCloud from syncing mail.
        /// </summary>
        [JsonPropertyName("iCloudBlockMail")]
        public bool? ICloudBlockMail { get; set; }
    
        /// <summary>
        /// Gets or sets i cloud block notes.
        /// Indicates whether or not to block iCloud from syncing notes.
        /// </summary>
        [JsonPropertyName("iCloudBlockNotes")]
        public bool? ICloudBlockNotes { get; set; }
    
        /// <summary>
        /// Gets or sets i cloud block photo library.
        /// Indicates whether or not to block iCloud Photo Library.
        /// </summary>
        [JsonPropertyName("iCloudBlockPhotoLibrary")]
        public bool? ICloudBlockPhotoLibrary { get; set; }
    
        /// <summary>
        /// Gets or sets i cloud block reminders.
        /// Indicates whether or not to block iCloud from syncing reminders.
        /// </summary>
        [JsonPropertyName("iCloudBlockReminders")]
        public bool? ICloudBlockReminders { get; set; }
    
        /// <summary>
        /// Gets or sets i cloud desktop and documents blocked.
        /// When TRUE the synchronization of cloud desktop and documents is blocked. When FALSE, synchronization of the cloud desktop and documents are allowed. Available for devices running macOS 10.12.4 and later.
        /// </summary>
        [JsonPropertyName("iCloudDesktopAndDocumentsBlocked")]
        public bool? ICloudDesktopAndDocumentsBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets i cloud private relay blocked.
        /// iCloud private relay is an iCloud+ service that prevents networks and servers from monitoring a person's activity across the internet. By blocking iCloud private relay, Apple will not encrypt the traffic leaving the device. Available for devices running macOS 12 and later.
        /// </summary>
        [JsonPropertyName("iCloudPrivateRelayBlocked")]
        public bool? ICloudPrivateRelayBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets i tunes block file sharing.
        /// Indicates whether or not to block files from being transferred using iTunes.
        /// </summary>
        [JsonPropertyName("iTunesBlockFileSharing")]
        public bool? ITunesBlockFileSharing { get; set; }
    
        /// <summary>
        /// Gets or sets i tunes block music service.
        /// Indicates whether or not to block Music service and revert Music app to classic mode.
        /// </summary>
        [JsonPropertyName("iTunesBlockMusicService")]
        public bool? ITunesBlockMusicService { get; set; }
    
        /// <summary>
        /// Gets or sets keyboard block dictation.
        /// Indicates whether or not to block the user from using dictation input.
        /// </summary>
        [JsonPropertyName("keyboardBlockDictation")]
        public bool? KeyboardBlockDictation { get; set; }
    
        /// <summary>
        /// Gets or sets keychain block cloud sync.
        /// Indicates whether or not iCloud keychain synchronization is blocked (macOS 10.12 and later).
        /// </summary>
        [JsonPropertyName("keychainBlockCloudSync")]
        public bool? KeychainBlockCloudSync { get; set; }
    
        /// <summary>
        /// Gets or sets multiplayer gaming blocked.
        /// TRUE prevents multiplayer gaming when using Game Center. FALSE allows multiplayer gaming when using Game Center. Available for devices running macOS versions 10.13 and later.
        /// </summary>
        [JsonPropertyName("multiplayerGamingBlocked")]
        public bool? MultiplayerGamingBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets password block air drop sharing.
        /// Indicates whether or not to block sharing passwords with the AirDrop passwords feature.
        /// </summary>
        [JsonPropertyName("passwordBlockAirDropSharing")]
        public bool? PasswordBlockAirDropSharing { get; set; }
    
        /// <summary>
        /// Gets or sets password block auto fill.
        /// Indicates whether or not to block the AutoFill Passwords feature.
        /// </summary>
        [JsonPropertyName("passwordBlockAutoFill")]
        public bool? PasswordBlockAutoFill { get; set; }
    
        /// <summary>
        /// Gets or sets password block fingerprint unlock.
        /// Indicates whether or not to block fingerprint unlock.
        /// </summary>
        [JsonPropertyName("passwordBlockFingerprintUnlock")]
        public bool? PasswordBlockFingerprintUnlock { get; set; }
    
        /// <summary>
        /// Gets or sets password block modification.
        /// Indicates whether or not to allow passcode modification.
        /// </summary>
        [JsonPropertyName("passwordBlockModification")]
        public bool? PasswordBlockModification { get; set; }
    
        /// <summary>
        /// Gets or sets password block proximity requests.
        /// Indicates whether or not to block requesting passwords from nearby devices.
        /// </summary>
        [JsonPropertyName("passwordBlockProximityRequests")]
        public bool? PasswordBlockProximityRequests { get; set; }
    
        /// <summary>
        /// Gets or sets password block simple.
        /// Block simple passwords.
        /// </summary>
        [JsonPropertyName("passwordBlockSimple")]
        public bool? PasswordBlockSimple { get; set; }
    
        /// <summary>
        /// Gets or sets password expiration days.
        /// Number of days before the password expires.
        /// </summary>
        [JsonPropertyName("passwordExpirationDays")]
        public Int32? PasswordExpirationDays { get; set; }
    
        /// <summary>
        /// Gets or sets password maximum attempt count.
        /// The number of allowed failed attempts to enter the passcode at the device's lock screen. Valid values 2 to 11
        /// </summary>
        [JsonPropertyName("passwordMaximumAttemptCount")]
        public Int32? PasswordMaximumAttemptCount { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum character set count.
        /// Number of character sets a password must contain. Valid values 0 to 4
        /// </summary>
        [JsonPropertyName("passwordMinimumCharacterSetCount")]
        public Int32? PasswordMinimumCharacterSetCount { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum length.
        /// Minimum length of passwords.
        /// </summary>
        [JsonPropertyName("passwordMinimumLength")]
        public Int32? PasswordMinimumLength { get; set; }
    
        /// <summary>
        /// Gets or sets password minutes of inactivity before lock.
        /// Minutes of inactivity required before a password is required.
        /// </summary>
        [JsonPropertyName("passwordMinutesOfInactivityBeforeLock")]
        public Int32? PasswordMinutesOfInactivityBeforeLock { get; set; }
    
        /// <summary>
        /// Gets or sets password minutes of inactivity before screen timeout.
        /// Minutes of inactivity required before the screen times out.
        /// </summary>
        [JsonPropertyName("passwordMinutesOfInactivityBeforeScreenTimeout")]
        public Int32? PasswordMinutesOfInactivityBeforeScreenTimeout { get; set; }
    
        /// <summary>
        /// Gets or sets password minutes until failed login reset.
        /// The number of minutes before the login is reset after the maximum number of unsuccessful login attempts is reached.
        /// </summary>
        [JsonPropertyName("passwordMinutesUntilFailedLoginReset")]
        public Int32? PasswordMinutesUntilFailedLoginReset { get; set; }
    
        /// <summary>
        /// Gets or sets password previous password block count.
        /// Number of previous passwords to block.
        /// </summary>
        [JsonPropertyName("passwordPreviousPasswordBlockCount")]
        public Int32? PasswordPreviousPasswordBlockCount { get; set; }
    
        /// <summary>
        /// Gets or sets password required.
        /// Whether or not to require a password.
        /// </summary>
        [JsonPropertyName("passwordRequired")]
        public bool? PasswordRequired { get; set; }
    
        /// <summary>
        /// Gets or sets password required type.
        /// Type of password that is required. Possible values are: deviceDefault, alphanumeric, numeric.
        /// </summary>
        [JsonPropertyName("passwordRequiredType")]
        public RequiredPasswordType? PasswordRequiredType { get; set; }
    
        /// <summary>
        /// Gets or sets privacy access controls.
        /// List of privacy preference policy controls. This collection can contain a maximum of 10000 elements.
        /// </summary>
        [JsonPropertyName("privacyAccessControls")]
        public IEnumerable<MacOSPrivacyAccessControlItem> PrivacyAccessControls { get; set; }
    
        /// <summary>
        /// Gets or sets safari block autofill.
        /// Indicates whether or not to block the user from using Auto fill in Safari.
        /// </summary>
        [JsonPropertyName("safariBlockAutofill")]
        public bool? SafariBlockAutofill { get; set; }
    
        /// <summary>
        /// Gets or sets screen capture blocked.
        /// Indicates whether or not to block the user from taking Screenshots.
        /// </summary>
        [JsonPropertyName("screenCaptureBlocked")]
        public bool? ScreenCaptureBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets software update major osdeferred install delay in days.
        /// Specify the number of days (1-90) to delay visibility of major OS software updates. Available for devices running macOS versions 11.3 and later. Valid values 0 to 90
        /// </summary>
        [JsonPropertyName("softwareUpdateMajorOSDeferredInstallDelayInDays")]
        public Int32? SoftwareUpdateMajorOSDeferredInstallDelayInDays { get; set; }
    
        /// <summary>
        /// Gets or sets software update minor osdeferred install delay in days.
        /// Specify the number of days (1-90) to delay visibility of minor OS software updates. Available for devices running macOS versions 11.3 and later. Valid values 0 to 90
        /// </summary>
        [JsonPropertyName("softwareUpdateMinorOSDeferredInstallDelayInDays")]
        public Int32? SoftwareUpdateMinorOSDeferredInstallDelayInDays { get; set; }
    
        /// <summary>
        /// Gets or sets software update non osdeferred install delay in days.
        /// Specify the number of days (1-90) to delay visibility of non-OS software updates. Available for devices running macOS versions 11.3 and later. Valid values 0 to 90
        /// </summary>
        [JsonPropertyName("softwareUpdateNonOSDeferredInstallDelayInDays")]
        public Int32? SoftwareUpdateNonOSDeferredInstallDelayInDays { get; set; }
    
        /// <summary>
        /// Gets or sets software updates enforced delay in days.
        /// Sets how many days a software update will be delyed for a supervised device. Valid values 0 to 90
        /// </summary>
        [JsonPropertyName("softwareUpdatesEnforcedDelayInDays")]
        public Int32? SoftwareUpdatesEnforcedDelayInDays { get; set; }
    
        /// <summary>
        /// Gets or sets spotlight block internet results.
        /// Indicates whether or not to block Spotlight from returning any results from an Internet search.
        /// </summary>
        [JsonPropertyName("spotlightBlockInternetResults")]
        public bool? SpotlightBlockInternetResults { get; set; }
    
        /// <summary>
        /// Gets or sets touch id timeout in hours.
        /// Maximum hours after which the user must enter their password to unlock the device instead of using Touch ID. Available for devices running macOS 12 and later. Valid values 0 to 2147483647
        /// </summary>
        [JsonPropertyName("touchIdTimeoutInHours")]
        public Int32? TouchIdTimeoutInHours { get; set; }
    
        /// <summary>
        /// Gets or sets update delay policy.
        /// Determines whether to delay OS and/or app updates for macOS. Possible values are: none, delayOSUpdateVisibility, delayAppUpdateVisibility, unknownFutureValue, delayMajorOsUpdateVisibility.
        /// </summary>
        [JsonPropertyName("updateDelayPolicy")]
        public MacOSSoftwareUpdateDelayPolicy? UpdateDelayPolicy { get; set; }
    
        /// <summary>
        /// Gets or sets wallpaper modification blocked.
        /// TRUE prevents the wallpaper from being changed. FALSE allows the wallpaper to be changed. Available for devices running macOS versions 10.13 and later.
        /// </summary>
        [JsonPropertyName("wallpaperModificationBlocked")]
        public bool? WallpaperModificationBlocked { get; set; }
    
    }
}

