using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum DeviceManangementIntentValueType {
        /// <summary>The setting value is an integer</summary>
        [EnumMember(Value = "integer")]
        Integer,
        /// <summary>The setting value is a boolean</summary>
        [EnumMember(Value = "boolean")]
        Boolean,
        /// <summary>The setting value is a string</summary>
        [EnumMember(Value = "string")]
        String,
        /// <summary>The setting value is a complex object</summary>
        [EnumMember(Value = "complex")]
        Complex,
        /// <summary>The setting value is a collection</summary>
        [EnumMember(Value = "collection")]
        Collection,
        /// <summary>The setting value is an abstract complex object</summary>
        [EnumMember(Value = "abstractComplex")]
        AbstractComplex,
    }
}
