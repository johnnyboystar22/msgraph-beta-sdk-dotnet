using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ExchangeIdFormat {
        [EnumMember(Value = "entryId")]
        EntryId,
        [EnumMember(Value = "ewsId")]
        EwsId,
        [EnumMember(Value = "immutableEntryId")]
        ImmutableEntryId,
        [EnumMember(Value = "restId")]
        RestId,
        [EnumMember(Value = "restImmutableEntryId")]
        RestImmutableEntryId,
    }
}
