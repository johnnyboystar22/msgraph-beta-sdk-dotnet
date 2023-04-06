using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Indicates the state of the anomaly. Eg: anomaly severity can be new, active, disabled, removed or other.</summary>
    public enum UserExperienceAnalyticsAnomalyState {
        /// <summary>Indicates the state of anomaly is new.</summary>
        [EnumMember(Value = "new")]
        New,
        /// <summary>Indicates the state of anomaly is active.</summary>
        [EnumMember(Value = "active")]
        Active,
        /// <summary>Indicates the state of anomaly is disabled.</summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>Indicates the state of anomaly is removed.</summary>
        [EnumMember(Value = "removed")]
        Removed,
        /// <summary>Indicates the state of anomaly is undefined.</summary>
        [EnumMember(Value = "other")]
        Other,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
