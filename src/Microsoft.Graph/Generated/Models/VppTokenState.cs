namespace Microsoft.Graph.Beta.Models {
    /// <summary>Possible states associated with an Apple Volume Purchase Program token.</summary>
    public enum VppTokenState {
        /// <summary>Default state.</summary>
        Unknown,
        /// <summary>Token is valid.</summary>
        Valid,
        /// <summary>Token is expired.</summary>
        Expired,
        /// <summary>Token is invalid.</summary>
        Invalid,
        /// <summary>Token is managed by another MDM Service.</summary>
        AssignedToExternalMDM,
        /// <summary>Token is associated with the same location as another token on the account.</summary>
        DuplicateLocationId,
    }
}
