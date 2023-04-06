using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Device scope configuration query operator. Possible values are: equals, notEquals, contains, notContains, greaterThan, lessThan. Default value: equals.</summary>
    public enum DeviceScopeOperator {
        /// <summary>No operator set for the device scope configuration.</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Operator for the device configuration query to be used (Equals).</summary>
        [EnumMember(Value = "equals")]
        Equals,
        /// <summary>Placeholder value for future expansion enums such as notEquals, contains, notContains, greaterThan, lessThan.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
