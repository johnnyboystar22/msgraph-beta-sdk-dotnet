namespace Microsoft.Graph.Beta.Models {
    /// <summary>Indicates the device scope status after the device scope has been enabled. Possible values are: none, computing, insufficientData or completed. Default value is none.</summary>
    public enum DeviceScopeStatus {
        /// <summary>Indicates the device scope is not enabled and there are no calculations in progress.</summary>
        None,
        /// <summary>Indicates the device scope is enabled and report metrics data are being recalculated by the service.</summary>
        Computing,
        /// <summary>Indicates the device scope is enabled but there is insufficient data to calculate results. The system requires information from at least 5 devices before calculations can occur.</summary>
        InsufficientData,
        /// <summary>Device scope is enabled and finished recalculating the report metric. Device scope is now ready to be used.</summary>
        Completed,
        /// <summary>Placeholder value for future expansion.</summary>
        UnknownFutureValue,
    }
}
