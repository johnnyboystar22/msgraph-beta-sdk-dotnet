using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Android keyguard feature.</summary>
    public enum AndroidKeyguardFeature {
        /// <summary>Not configured; this value is ignored.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Camera usage when on secure keyguard screens.</summary>
        [EnumMember(Value = "camera")]
        Camera,
        /// <summary>Showing notifications when on secure keyguard screens.</summary>
        [EnumMember(Value = "notifications")]
        Notifications,
        /// <summary>Showing unredacted notifications when on secure keyguard screens.</summary>
        [EnumMember(Value = "unredactedNotifications")]
        UnredactedNotifications,
        /// <summary>Trust agent state when on secure keyguard screens.</summary>
        [EnumMember(Value = "trustAgents")]
        TrustAgents,
        /// <summary>Fingerprint sensor usage when on secure keyguard screens.</summary>
        [EnumMember(Value = "fingerprint")]
        Fingerprint,
        /// <summary>Notification text entry when on secure keyguard screens.</summary>
        [EnumMember(Value = "remoteInput")]
        RemoteInput,
        /// <summary>All keyguard features when on secure keyguard screens.</summary>
        [EnumMember(Value = "allFeatures")]
        AllFeatures,
        /// <summary>Face authentication on secure keyguard screens.</summary>
        [EnumMember(Value = "face")]
        Face,
        /// <summary>Iris authentication on secure keyguard screens.</summary>
        [EnumMember(Value = "iris")]
        Iris,
        /// <summary>All biometric authentication on secure keyguard screens.</summary>
        [EnumMember(Value = "biometrics")]
        Biometrics,
    }
}
