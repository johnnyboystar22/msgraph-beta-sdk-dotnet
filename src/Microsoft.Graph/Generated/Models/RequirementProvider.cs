namespace Microsoft.Graph.Beta.Models {
    public enum RequirementProvider {
        User,
        Request,
        ServicePrincipal,
        V1ConditionalAccess,
        MultiConditionalAccess,
        TenantSessionRiskPolicy,
        AccountCompromisePolicies,
        V1ConditionalAccessDependency,
        V1ConditionalAccessPolicyIdRequested,
        MfaRegistrationRequiredByIdentityProtectionPolicy,
        BaselineProtection,
        MfaRegistrationRequiredByBaselineProtection,
        MfaRegistrationRequiredByMultiConditionalAccess,
        EnforcedForCspAdmins,
        SecurityDefaults,
        MfaRegistrationRequiredBySecurityDefaults,
        ProofUpCodeRequest,
        CrossTenantOutboundRule,
        GpsLocationCondition,
        RiskBasedPolicy,
        UnknownFutureValue,
    }
}
