using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum MessageEventType {
        [EnumMember(Value = "received")]
        Received,
        [EnumMember(Value = "sent")]
        Sent,
        [EnumMember(Value = "delivered")]
        Delivered,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "processingFailed")]
        ProcessingFailed,
        [EnumMember(Value = "distributionGroupExpanded")]
        DistributionGroupExpanded,
        [EnumMember(Value = "submitted")]
        Submitted,
        [EnumMember(Value = "delayed")]
        Delayed,
        [EnumMember(Value = "redirected")]
        Redirected,
        [EnumMember(Value = "resolved")]
        Resolved,
        [EnumMember(Value = "dropped")]
        Dropped,
        [EnumMember(Value = "recipientsAdded")]
        RecipientsAdded,
        [EnumMember(Value = "malwareDetected")]
        MalwareDetected,
        [EnumMember(Value = "malwareDetectedInMessage")]
        MalwareDetectedInMessage,
        [EnumMember(Value = "malwareDetectedInAttachment")]
        MalwareDetectedInAttachment,
        [EnumMember(Value = "ttZapped")]
        TtZapped,
        [EnumMember(Value = "ttDelivered")]
        TtDelivered,
        [EnumMember(Value = "spamDetected")]
        SpamDetected,
        [EnumMember(Value = "transportRuleTriggered")]
        TransportRuleTriggered,
        [EnumMember(Value = "dlpRuleTriggered")]
        DlpRuleTriggered,
        [EnumMember(Value = "journaled")]
        Journaled,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
