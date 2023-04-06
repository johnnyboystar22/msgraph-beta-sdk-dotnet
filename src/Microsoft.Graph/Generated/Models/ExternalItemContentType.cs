using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ExternalItemContentType {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "html")]
        Html,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
