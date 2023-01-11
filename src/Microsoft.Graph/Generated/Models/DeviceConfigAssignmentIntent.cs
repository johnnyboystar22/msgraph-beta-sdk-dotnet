namespace Microsoft.Graph.Beta.Models {
    /// <summary>The administrator intent for the assignment of the profile.</summary>
    public enum DeviceConfigAssignmentIntent {
        /// <summary>Ensure that the configuration profile is applied to the devices in the assignment.</summary>
        Apply,
        /// <summary>Ensure that the configuration profile is removed from devices that have previously installed the configuration profile.</summary>
        Remove,
    }
}
