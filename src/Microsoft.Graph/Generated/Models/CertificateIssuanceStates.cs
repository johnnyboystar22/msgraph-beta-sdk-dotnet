using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Certificate Issuance State Options.</summary>
    public enum CertificateIssuanceStates {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "challengeIssued")]
        ChallengeIssued,
        [EnumMember(Value = "challengeIssueFailed")]
        ChallengeIssueFailed,
        [EnumMember(Value = "requestCreationFailed")]
        RequestCreationFailed,
        [EnumMember(Value = "requestSubmitFailed")]
        RequestSubmitFailed,
        [EnumMember(Value = "challengeValidationSucceeded")]
        ChallengeValidationSucceeded,
        [EnumMember(Value = "challengeValidationFailed")]
        ChallengeValidationFailed,
        [EnumMember(Value = "issueFailed")]
        IssueFailed,
        [EnumMember(Value = "issuePending")]
        IssuePending,
        [EnumMember(Value = "issued")]
        Issued,
        [EnumMember(Value = "responseProcessingFailed")]
        ResponseProcessingFailed,
        [EnumMember(Value = "responsePending")]
        ResponsePending,
        [EnumMember(Value = "enrollmentSucceeded")]
        EnrollmentSucceeded,
        [EnumMember(Value = "enrollmentNotNeeded")]
        EnrollmentNotNeeded,
        [EnumMember(Value = "revoked")]
        Revoked,
        [EnumMember(Value = "removedFromCollection")]
        RemovedFromCollection,
        [EnumMember(Value = "renewVerified")]
        RenewVerified,
        [EnumMember(Value = "installFailed")]
        InstallFailed,
        [EnumMember(Value = "installed")]
        Installed,
        [EnumMember(Value = "deleteFailed")]
        DeleteFailed,
        [EnumMember(Value = "deleted")]
        Deleted,
        [EnumMember(Value = "renewalRequested")]
        RenewalRequested,
        [EnumMember(Value = "requested")]
        Requested,
    }
}
