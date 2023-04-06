using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Windows privacy data category specifier for privacy data access.</summary>
    public enum WindowsPrivacyDataCategory {
        /// <summary>No access level specified, no intents. Device may behave either as in UserInControl or ForceAllow. It may depend on the privacy data been accessed, Windows versions and other factors.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Let apps access user’s name, picture and other account information created in Microsoft account. Added in Windows 10, version 1607.</summary>
        [EnumMember(Value = "accountInfo")]
        AccountInfo,
        /// <summary>Allow apps to receive information, send notifications, and stay up-to-date, even when the user is not using them. Be aware that when disabling communication apps (Email, Voice, etc) from background access these apps may or may not function as they are with the background access. Added in Windows 10, version 1703.</summary>
        [EnumMember(Value = "appsRunInBackground")]
        AppsRunInBackground,
        /// <summary>Let apps access user’s calendar. Added in Windows 10, version 1607.</summary>
        [EnumMember(Value = "calendar")]
        Calendar,
        /// <summary>Let apps access user’s call history. Added in Windows 10, version 1607.</summary>
        [EnumMember(Value = "callHistory")]
        CallHistory,
        /// <summary>Let apps access the camera on user’s device. Added in Windows 10, version 1607.</summary>
        [EnumMember(Value = "camera")]
        Camera,
        /// <summary>Let apps access user’s contact information. Added in Windows 10, version 1607.</summary>
        [EnumMember(Value = "contacts")]
        Contacts,
        /// <summary>Let apps access diagnostic information about other running apps. Added in Windows 10, version 1703.</summary>
        [EnumMember(Value = "diagnosticsInfo")]
        DiagnosticsInfo,
        /// <summary>Let apps access and send email. Added in Windows 10, version 1607.</summary>
        [EnumMember(Value = "email")]
        Email,
        /// <summary>Let apps access the precise location data of device user. Added in Windows 10, version 1607.</summary>
        [EnumMember(Value = "location")]
        Location,
        /// <summary>Let apps read or send messages, text or MMS. Added in Windows 10, version 1607.</summary>
        [EnumMember(Value = "messaging")]
        Messaging,
        /// <summary>Let apps use microphone on the user device. Added in Windows 10, version 1607.</summary>
        [EnumMember(Value = "microphone")]
        Microphone,
        /// <summary>Let apps use motion data generated on the device user. Added in Windows 10, version 1607.</summary>
        [EnumMember(Value = "motion")]
        Motion,
        /// <summary>Let apps access user’s notifications. Added in Windows 10, version 1607.</summary>
        [EnumMember(Value = "notifications")]
        Notifications,
        /// <summary>Let apps access phone data and make phone calls. Added in Windows 10, version 1607.</summary>
        [EnumMember(Value = "phone")]
        Phone,
        /// <summary>Let apps use radios, including Bluetooth, to send and receive data. Added in Windows 10, version 1607.</summary>
        [EnumMember(Value = "radios")]
        Radios,
        /// <summary>Let apps access Task Scheduler. Added in Windows 10, version 1703.</summary>
        [EnumMember(Value = "tasks")]
        Tasks,
        /// <summary>Let apps automatically share and sync info with wireless devices that don’t explicitly pair with user’s device. Added in Windows 10, version 1607.</summary>
        [EnumMember(Value = "syncWithDevices")]
        SyncWithDevices,
        /// <summary>Let apps access trusted devices. Added in Windows 10, version 1607.</summary>
        [EnumMember(Value = "trustedDevices")]
        TrustedDevices,
    }
}
