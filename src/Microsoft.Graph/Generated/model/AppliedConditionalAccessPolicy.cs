// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type AppliedConditionalAccessPolicy.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AppliedConditionalAccessPolicy>))]
    public partial class AppliedConditionalAccessPolicy
    {

        /// <summary>
        /// Gets or sets authenticationStrength.
        /// The custom authentication strength enforced in a Conditional Access policy.
        /// </summary>
        [JsonPropertyName("authenticationStrength")]
        public AuthenticationStrength AuthenticationStrength { get; set; }
    
        /// <summary>
        /// Gets or sets conditionsNotSatisfied.
        /// Refers to the conditional access policy conditions that are not satisfied. The possible values are: none, application, users, devicePlatform, location, clientType, signInRisk, userRisk, time, deviceState, client,ipAddressSeenByAzureAD,ipAddressSeenByResourceProvider,unknownFutureValue,servicePrincipals,servicePrincipalRisk, authenticationFlows, insiderRisk . Note that you must use the Prefer: include-unknown-enum-members request header to get the following values in this evolvable enum: servicePrincipals,servicePrincipalRisk, authenticationFlows, insiderRisk. conditionalAccessConditions is a multi-valued enumeration and the property can contain multiple values in a comma-separated list.
        /// </summary>
        [JsonPropertyName("conditionsNotSatisfied")]
        public IEnumerable<ConditionalAccessConditions> ConditionsNotSatisfied { get; set; }
    
        /// <summary>
        /// Gets or sets conditionsSatisfied.
        /// Refers to the conditional access policy conditions that are satisfied. The possible values are: none, application, users, devicePlatform, location, clientType, signInRisk, userRisk, time, deviceState, client,ipAddressSeenByAzureAD,ipAddressSeenByResourceProvider,unknownFutureValue,servicePrincipals,servicePrincipalRisk, authenticationFlows, insiderRisk. Note that you must use the Prefer: include-unknown-enum-members request header to get the following values in this evolvable enum: servicePrincipals,servicePrincipalRisk, authenticationFlows, insiderRisk. conditionalAccessConditions is a multi-valued enumeration and the property can contain multiple values in a comma-separated list.
        /// </summary>
        [JsonPropertyName("conditionsSatisfied")]
        public IEnumerable<ConditionalAccessConditions> ConditionsSatisfied { get; set; }
    
        /// <summary>
        /// Gets or sets displayName.
        /// Name of the conditional access policy.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets enforcedGrantControls.
        /// Refers to the grant controls enforced by the conditional access policy (example: 'Require multi-factor authentication').
        /// </summary>
        [JsonPropertyName("enforcedGrantControls")]
        public IEnumerable<string> EnforcedGrantControls { get; set; }
    
        /// <summary>
        /// Gets or sets enforcedSessionControls.
        /// Refers to the session controls enforced by the conditional access policy (example: 'Require app enforced controls').
        /// </summary>
        [JsonPropertyName("enforcedSessionControls")]
        public IEnumerable<string> EnforcedSessionControls { get; set; }
    
        /// <summary>
        /// Gets or sets excludeRulesSatisfied.
        /// List of key-value pairs containing each matched exclude condition in the conditional access policy. Example: [{'devicePlatform' : 'DevicePlatform'}] means the policy didn't apply, because the DevicePlatform condition was a match.
        /// </summary>
        [JsonPropertyName("excludeRulesSatisfied")]
        public IEnumerable<ConditionalAccessRuleSatisfied> ExcludeRulesSatisfied { get; set; }
    
        /// <summary>
        /// Gets or sets id.
        /// Identifier of the conditional access policy.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or sets includeRulesSatisfied.
        /// List of key-value pairs containing each matched include condition in the conditional access policy. Example: [{ 'application' : 'AllApps'}, {'users': 'Group'}], meaning Application condition was a match because AllApps are included and Users condition was a match because the user was part of the included Group rule.
        /// </summary>
        [JsonPropertyName("includeRulesSatisfied")]
        public IEnumerable<ConditionalAccessRuleSatisfied> IncludeRulesSatisfied { get; set; }
    
        /// <summary>
        /// Gets or sets result.
        /// Indicates the result of the CA policy that was triggered. Possible values are: success, failure, notApplied (Policy isn't applied because policy conditions were not met),notEnabled (This is due to the policy in disabled state), unknown, unknownFutureValue, reportOnlySuccess, reportOnlyFailure, reportOnlyNotApplied, reportOnlyInterrupted. Note that you must use the Prefer: include-unknown-enum-members request header to get the following values in this evolvable enum: reportOnlySuccess, reportOnlyFailure, reportOnlyNotApplied, reportOnlyInterrupted.
        /// </summary>
        [JsonPropertyName("result")]
        public AppliedConditionalAccessPolicyResult? Result { get; set; }
    
        /// <summary>
        /// Gets or sets sessionControlsNotSatisfied.
        /// Refers to the session controls that a sign-in activity did not satisfy. (Example: Application enforced Restrictions).
        /// </summary>
        [JsonPropertyName("sessionControlsNotSatisfied")]
        public IEnumerable<string> SessionControlsNotSatisfied { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
