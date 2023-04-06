using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum MicrosoftStoreForBusinessLicenseType {
        [EnumMember(Value = "offline")]
        Offline,
        [EnumMember(Value = "online")]
        Online,
    }
}
