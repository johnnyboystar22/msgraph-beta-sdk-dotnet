using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Indicates the category of the anomaly. Eg: anomaly type can be device, application, stop error, driver or other.</summary>
    public enum UserExperienceAnalyticsAnomalyType {
        /// <summary>Indicates the detected anomaly is due to certain devices.</summary>
        [EnumMember(Value = "device")]
        Device,
        /// <summary>Indicates the detected anomaly is due to a specific application.</summary>
        [EnumMember(Value = "application")]
        Application,
        /// <summary>Indicates the detected anomaly is due to a specific stop error.</summary>
        [EnumMember(Value = "stopError")]
        StopError,
        /// <summary>Indicates the detected anomaly is due to a specific driver.</summary>
        [EnumMember(Value = "driver")]
        Driver,
        /// <summary>Indicates the category of detected anomaly is undefined.</summary>
        [EnumMember(Value = "other")]
        Other,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
