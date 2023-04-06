using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public enum ManagementParameterValueType {
        [EnumMember(Value = "string")]
        String,
        [EnumMember(Value = "integer")]
        Integer,
        [EnumMember(Value = "boolean")]
        Boolean,
        [EnumMember(Value = "guid")]
        Guid,
        [EnumMember(Value = "stringCollection")]
        StringCollection,
        [EnumMember(Value = "integerCollection")]
        IntegerCollection,
        [EnumMember(Value = "booleanCollection")]
        BooleanCollection,
        [EnumMember(Value = "guidCollection")]
        GuidCollection,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
