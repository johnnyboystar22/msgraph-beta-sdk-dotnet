using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ExpirationRequirement {
        [EnumMember(Value = "rememberMultifactorAuthenticationOnTrustedDevices")]
        RememberMultifactorAuthenticationOnTrustedDevices,
        [EnumMember(Value = "tenantTokenLifetimePolicy")]
        TenantTokenLifetimePolicy,
        [EnumMember(Value = "audienceTokenLifetimePolicy")]
        AudienceTokenLifetimePolicy,
        [EnumMember(Value = "signInFrequencyPeriodicReauthentication")]
        SignInFrequencyPeriodicReauthentication,
        [EnumMember(Value = "ngcMfa")]
        NgcMfa,
        [EnumMember(Value = "signInFrequencyEveryTime")]
        SignInFrequencyEveryTime,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
