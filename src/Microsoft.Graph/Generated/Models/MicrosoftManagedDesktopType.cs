using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum MicrosoftManagedDesktopType {
        [EnumMember(Value = "notManaged")]
        NotManaged,
        [EnumMember(Value = "premiumManaged")]
        PremiumManaged,
        [EnumMember(Value = "standardManaged")]
        StandardManaged,
        [EnumMember(Value = "starterManaged")]
        StarterManaged,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
