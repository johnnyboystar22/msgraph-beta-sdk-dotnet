using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum EventType {
        [EnumMember(Value = "singleInstance")]
        SingleInstance,
        [EnumMember(Value = "occurrence")]
        Occurrence,
        [EnumMember(Value = "exception")]
        Exception,
        [EnumMember(Value = "seriesMaster")]
        SeriesMaster,
    }
}
