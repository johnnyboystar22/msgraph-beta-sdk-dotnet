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
    /// The type SynchronizationSecretKeyStringValuePair.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<SynchronizationSecretKeyStringValuePair>))]
    public partial class SynchronizationSecretKeyStringValuePair
    {

        /// <summary>
        /// Gets or sets key.
        /// Possible values are: None, UserName, Password, SecretToken, AppKey, BaseAddress, ClientIdentifier, ClientSecret, SingleSignOnType, Sandbox, Url, Domain, ConsumerKey, ConsumerSecret, TokenKey, TokenExpiration, Oauth2AccessToken, Oauth2AccessTokenCreationTime, Oauth2RefreshToken, SyncAll, InstanceName, Oauth2ClientId, Oauth2ClientSecret, CompanyId, UpdateKeyOnSoftDelete, SynchronizationSchedule, SystemOfRecord, SandboxName, EnforceDomain, SyncNotificationSettings, SkipOutOfScopeDeletions, Oauth2AuthorizationCode, Oauth2RedirectUri, ApplicationTemplateIdentifier, Oauth2TokenExchangeUri, Oauth2AuthorizationUri, AuthenticationType, Server, PerformInboundEntitlementGrants, HardDeletesEnabled, SyncAgentCompatibilityKey, SyncAgentADContainer, ValidateDomain, TestReferences, ConnectionString.
        /// </summary>
        [JsonPropertyName("key")]
        public SynchronizationSecret? Key { get; set; }
    
        /// <summary>
        /// Gets or sets value.
        /// The value of the secret.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    
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
