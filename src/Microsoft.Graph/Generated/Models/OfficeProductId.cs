using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The Enum to specify the Office365 ProductIds that represent the Office365 Suite SKUs.</summary>
    public enum OfficeProductId {
        [EnumMember(Value = "o365ProPlusRetail")]
        O365ProPlusRetail,
        [EnumMember(Value = "o365BusinessRetail")]
        O365BusinessRetail,
        [EnumMember(Value = "visioProRetail")]
        VisioProRetail,
        [EnumMember(Value = "projectProRetail")]
        ProjectProRetail,
    }
}
