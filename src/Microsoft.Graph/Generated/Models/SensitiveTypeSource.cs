using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum SensitiveTypeSource {
        [EnumMember(Value = "outOfBox")]
        OutOfBox,
        [EnumMember(Value = "tenant")]
        Tenant,
    }
}
