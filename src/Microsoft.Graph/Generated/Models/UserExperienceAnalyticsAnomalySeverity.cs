using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Indicates the severity of the anomaly. Eg: anomaly severity can be high, medium, low, informational or other.</summary>
    public enum UserExperienceAnalyticsAnomalySeverity {
        /// <summary>Indicates the anomaly is of high severity.</summary>
        [EnumMember(Value = "high")]
        High,
        /// <summary>Indicates the anomaly is of medium severity.</summary>
        [EnumMember(Value = "medium")]
        Medium,
        /// <summary>Indicates the anomaly is of low severity.</summary>
        [EnumMember(Value = "low")]
        Low,
        /// <summary>Indicates the anomaly is of informational severity.</summary>
        [EnumMember(Value = "informational")]
        Informational,
        /// <summary>Indicates the severity of anomaly is undefined.</summary>
        [EnumMember(Value = "other")]
        Other,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
