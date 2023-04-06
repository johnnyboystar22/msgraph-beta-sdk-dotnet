using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.CallRecords {
    public enum PstnCallDurationSource {
        [EnumMember(Value = "microsoft")]
        Microsoft,
        [EnumMember(Value = "operator")]
        Operator,
    }
}
