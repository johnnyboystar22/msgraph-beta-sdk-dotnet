namespace Microsoft.Graph.Beta.Models {
    /// <summary>Possible types of reasons for an Apple Volume Purchase Program token action failure.</summary>
    public enum VppTokenActionFailureReason {
        /// <summary>None.</summary>
        None,
        /// <summary>There was an error on Apple&apos;s service.</summary>
        AppleFailure,
        /// <summary>There was an internal error.</summary>
        InternalError,
        /// <summary>There was an error because the Apple Volume Purchase Program token was expired.</summary>
        ExpiredVppToken,
        /// <summary>There was an error because the Apple Volume Purchase Program Push Notification certificate expired.</summary>
        ExpiredApplePushNotificationCertificate,
    }
}
