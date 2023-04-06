using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Android Work Profile required password type.</summary>
    public enum AndroidWorkProfileRequiredPasswordType {
        /// <summary>Device default value, no intent.</summary>
        [EnumMember(Value = "deviceDefault")]
        DeviceDefault,
        /// <summary>Low security biometrics based password required.</summary>
        [EnumMember(Value = "lowSecurityBiometric")]
        LowSecurityBiometric,
        /// <summary>Required.</summary>
        [EnumMember(Value = "required")]
        Required,
        /// <summary>At least numeric password required.</summary>
        [EnumMember(Value = "atLeastNumeric")]
        AtLeastNumeric,
        /// <summary>Numeric complex password required.</summary>
        [EnumMember(Value = "numericComplex")]
        NumericComplex,
        /// <summary>At least alphabetic password required.</summary>
        [EnumMember(Value = "atLeastAlphabetic")]
        AtLeastAlphabetic,
        /// <summary>At least alphanumeric password required.</summary>
        [EnumMember(Value = "atLeastAlphanumeric")]
        AtLeastAlphanumeric,
        /// <summary>At least alphanumeric with symbols password required.</summary>
        [EnumMember(Value = "alphanumericWithSymbols")]
        AlphanumericWithSymbols,
    }
}
