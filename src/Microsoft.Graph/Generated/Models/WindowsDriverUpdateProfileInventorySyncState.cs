using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Windows DnF update inventory sync state.</summary>
    public enum WindowsDriverUpdateProfileInventorySyncState {
        /// <summary>Pending sync.</summary>
        [EnumMember(Value = "pending")]
        Pending,
        /// <summary>Successful sync.</summary>
        [EnumMember(Value = "success")]
        Success,
        /// <summary>Failed sync.</summary>
        [EnumMember(Value = "failure")]
        Failure,
    }
}
