namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceAppManagement singleton.</summary>
    public enum ManagedAppPhoneNumberRedirectLevel {
        /// <summary>Sharing is allowed to all apps.</summary>
        AllApps,
        /// <summary>Sharing is allowed to all managed apps.</summary>
        ManagedApps,
        /// <summary>Sharing is allowed to a custom app.</summary>
        CustomApp,
        /// <summary>Sharing between apps is blocked.</summary>
        Blocked,
    }
}
