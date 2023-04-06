using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Represents the expected type for a macOS custom attribute script value.</summary>
    public enum DeviceCustomAttributeValueType {
        /// <summary>Indicates the value for a custom attribute script is an integer.</summary>
        [EnumMember(Value = "integer")]
        Integer,
        /// <summary>Indicates the value for a custom attribute script is a string.</summary>
        [EnumMember(Value = "string")]
        String,
        /// <summary>Indicates the value for a custom attribute script is a date conforming to ISO 8601.</summary>
        [EnumMember(Value = "dateTime")]
        DateTime,
    }
}
