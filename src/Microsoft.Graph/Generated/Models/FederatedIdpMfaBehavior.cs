using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum FederatedIdpMfaBehavior {
        [EnumMember(Value = "acceptIfMfaDoneByFederatedIdp")]
        AcceptIfMfaDoneByFederatedIdp,
        [EnumMember(Value = "enforceMfaByFederatedIdp")]
        EnforceMfaByFederatedIdp,
        [EnumMember(Value = "rejectMfaByFederatedIdp")]
        RejectMfaByFederatedIdp,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
