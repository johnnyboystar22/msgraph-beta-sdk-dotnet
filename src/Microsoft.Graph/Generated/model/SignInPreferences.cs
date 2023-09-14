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
    /// The type SignInPreferences.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<SignInPreferences>))]
    public partial class SignInPreferences
    {

        /// <summary>
        /// Gets or sets isSystemPreferredAuthenticationMethodEnabled.
        /// Indicates whether the credential preferences of the system are enabled.
        /// </summary>
        [JsonPropertyName("isSystemPreferredAuthenticationMethodEnabled")]
        public bool? IsSystemPreferredAuthenticationMethodEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets userPreferredMethodForSecondaryAuthentication.
        /// The default second-factor method used by the user when signing in. If a user is enabled for system-preferred authentication, then this value is ignored except for a few scenarios where a user is authenticating via NPS extension or ADFS adapter. Possible values are push, oath, voiceMobile, voiceAlternateMobile, voiceOffice, sms, and unknownFutureValue
        /// </summary>
        [JsonPropertyName("userPreferredMethodForSecondaryAuthentication")]
        public UserDefaultAuthenticationMethodType? UserPreferredMethodForSecondaryAuthentication { get; set; }
    
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
