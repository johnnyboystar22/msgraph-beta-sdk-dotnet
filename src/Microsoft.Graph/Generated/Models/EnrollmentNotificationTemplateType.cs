using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>This enum indicates the Template type for which the enrollment notification applies.</summary>
    public enum EnrollmentNotificationTemplateType {
        /// <summary>Email Notification</summary>
        [EnumMember(Value = "email")]
        Email,
        /// <summary>Push Notification</summary>
        [EnumMember(Value = "push")]
        Push,
        /// <summary>Unknown Type</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
