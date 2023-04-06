using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Cancel or confirm scheduled retire </summary>
    public enum ScheduledRetireState {
        /// <summary>CancelRetire</summary>
        [EnumMember(Value = "cancelRetire")]
        CancelRetire,
        /// <summary>ConfirmRetire</summary>
        [EnumMember(Value = "confirmRetire")]
        ConfirmRetire,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
