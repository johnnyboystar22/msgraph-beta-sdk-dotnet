using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Power action types</summary>
    public enum PowerActionType {
        /// <summary>Not configured</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>No action</summary>
        [EnumMember(Value = "noAction")]
        NoAction,
        /// <summary>Put device in sleep state</summary>
        [EnumMember(Value = "sleep")]
        Sleep,
        /// <summary>Put device in hibernate state</summary>
        [EnumMember(Value = "hibernate")]
        Hibernate,
        /// <summary>Shutdown device</summary>
        [EnumMember(Value = "shutdown")]
        Shutdown,
    }
}
