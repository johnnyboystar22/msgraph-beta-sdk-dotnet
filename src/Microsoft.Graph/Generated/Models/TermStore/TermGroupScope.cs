using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.TermStore {
    public enum TermGroupScope {
        [EnumMember(Value = "global")]
        Global,
        [EnumMember(Value = "system")]
        System,
        [EnumMember(Value = "siteCollection")]
        SiteCollection,
    }
}
