using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum ContentFormat {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "html")]
        Html,
        [EnumMember(Value = "markdown")]
        Markdown,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
